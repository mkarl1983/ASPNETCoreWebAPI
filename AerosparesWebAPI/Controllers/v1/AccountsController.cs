using System;
using System.Linq;
using AutoMapper;
using AerosparesWebAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using AerosparesWebAPI.Repositories;
using System.Collections.Generic;
using AerosparesWebAPI.Entities;
using AerosparesWebAPI.Helpers;
using AerosparesWebAPI.Services;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using AutoMapper.Internal;

namespace AerosparesWebAPI.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUrlHelper _urlHelper;
        private readonly IMapper _mapper;
        private readonly IAddressRestService _addressRepository;
        private string _fakeAddress;

        public AccountsController(
            IUrlHelper urlHelper,
            IAccountRepository accountRepository,
            IAddressRestService addressRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _addressRepository = addressRepository;
            _mapper = mapper;
            _urlHelper = urlHelper;
        }

        [HttpGet(Name = nameof(GetAllAccounts))]
        public async Task<ActionResult> GetAllAccounts(ApiVersion version, [FromQuery] QueryParameters queryParameters)
        {
            List<AccountEntity> accountItems = _accountRepository.GetAll(queryParameters).ToList();

            var allItemCount = _accountRepository.Count();

            var paginationMetadata = new
            {
                totalCount = allItemCount,
                pageSize = queryParameters.PageCount,
                currentPage = queryParameters.Page,
                totalPages = queryParameters.GetTotalPages(allItemCount)
            };

            Response.Headers.Add("X-Pagination",
                Newtonsoft.Json.JsonConvert.SerializeObject(paginationMetadata));

           

            var linkslist = CreateLinksForCollection(queryParameters, allItemCount, version);

            if (string.IsNullOrEmpty(_fakeAddress))
            {
                var address = await _addressRepository.GetAddressByIdAsync(1);
                _fakeAddress = string.Format("{0}, {1}", address.city, address.postcode);
            }

            var toReturn = accountItems.Select(x => ExpandSingleAccountItemAsync(x, version));

            return Ok(new
            {
                value = toReturn,
                links = linkslist
            });
        }

        [HttpGet("GetAccountTypes", Name = nameof(GetAccountTypes))]
        public ActionResult GetAccountTypes(ApiVersion version, [FromQuery] QueryParameters queryParameters)
        {
            List<AccountTypeEntity> accountTypeItems = _accountRepository.GetAccountTypes(queryParameters).ToList();

            IEnumerable<AccountTypeDto> dtos = accountTypeItems.Select(x => _mapper.Map<AccountTypeDto>(x));
            return Ok(new
            {
                value = dtos

            });
        }

        [HttpGet]
        [Route("{id:int}", Name = nameof(GetSingleAccount))]
        public ActionResult GetSingleAccount(ApiVersion version, int id)
        {
            AccountEntity accountItem = _accountRepository.GetSingle(id);

            if (accountItem == null)
            {
                return NotFound();
            }

            return Ok(ExpandSingleAccountItemAsync(accountItem, version));
        }

        [HttpPost(Name = nameof(AddAccount))]
        public ActionResult<AccountDto> AddAccount(ApiVersion version, [FromBody] AccountCreateDto accountCreateDto)
        {
            if (accountCreateDto == null)
            {
                return BadRequest();
            }

            AccountEntity toAdd = _mapper.Map<AccountEntity>(accountCreateDto);

            _accountRepository.Add(toAdd);

            if (!_accountRepository.Save())
            {
                throw new Exception("Creating a accountitem failed on save.");
            }

            AccountEntity newAccountItem = _accountRepository.GetSingle(toAdd.Id);

            return CreatedAtRoute(nameof(GetSingleAccount), new { version = version.ToString(), id = newAccountItem.Id },
                _mapper.Map<AccountDto>(newAccountItem));
        }

        [HttpPatch("{id:int}", Name = nameof(PartiallyUpdateAccount))]
        public ActionResult<AccountDto> PartiallyUpdateAccount(int id, [FromBody] JsonPatchDocument<AccountUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest();
            }

            AccountEntity existingEntity = _accountRepository.GetSingle(id);

            if (existingEntity == null)
            {
                return NotFound();
            }

            AccountUpdateDto accountUpdateDto = _mapper.Map<AccountUpdateDto>(existingEntity);
            patchDoc.ApplyTo(accountUpdateDto);

            TryValidateModel(accountUpdateDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(accountUpdateDto, existingEntity);
            AccountEntity updated = _accountRepository.Update(id, existingEntity);

            if (!_accountRepository.Save())
            {
                throw new Exception("Updating a accountitem failed on save.");
            }

            return Ok(_mapper.Map<AccountDto>(updated));
        }

        [HttpDelete]
        [Route("{id:int}", Name = nameof(RemoveAccount))]
        public ActionResult RemoveAccount(int id)
        {
            AccountEntity accountitem = _accountRepository.GetSingle(id);

            if (accountitem == null)
            {
                return NotFound();
            }

            _accountRepository.Delete(id);

            if (!_accountRepository.Save())
            {
                throw new Exception("Deleting a accountitem failed on save.");
            }

            return NoContent();
        }

        [HttpPut]
        [Route("{id:int}", Name = nameof(UpdateAccount))]
        public ActionResult<AccountDto> UpdateAccount(int id, [FromBody] AccountUpdateDto accountUpdateDto)
        {
            if (accountUpdateDto == null)
            {
                return BadRequest();
            }

            var existingAccountItem = _accountRepository.GetSingle(id);

            if (existingAccountItem == null)
            {
                return NotFound();
            }

            _mapper.Map(accountUpdateDto, existingAccountItem);

            _accountRepository.Update(id, existingAccountItem);

            if (!_accountRepository.Save())
            {
                throw new Exception("Updating a accountitem failed on save.");
            }

            return Ok(_mapper.Map<AccountDto>(existingAccountItem));
        }

        [HttpGet("GetRandomAccount", Name = nameof(GetRandomAccount))]
        public ActionResult GetRandomAccount()
        {
            ICollection<AccountEntity> accountItems = _accountRepository.GetRandomAccount();

            IEnumerable<AccountDto> dtos = accountItems
                .Select(x => _mapper.Map<AccountDto>(x));

            var linkslist = new List<LinkDto>();

            // self 
            linkslist.Add(new LinkDto(_urlHelper.Link(nameof(GetRandomAccount), null), "self", "GET"));

            return Ok(new
            {
                value = dtos,
                links = linkslist
            });
        }

        private List<LinkDto> CreateLinksForCollection(QueryParameters queryParameters, int totalCount, ApiVersion version)
        {
            var linkslist = new List<LinkDto>();

            // self 
            linkslist.Add(new LinkDto(_urlHelper.Link(nameof(GetAllAccounts), new
            {
                pagecount = queryParameters.PageCount,
                page = queryParameters.Page,
                orderby = queryParameters.OrderBy
            }), "self", "GET"));

            linkslist.Add(new LinkDto(_urlHelper.Link(nameof(GetAllAccounts), new
            {
                pagecount = queryParameters.PageCount,
                page = 1,
                orderby = queryParameters.OrderBy
            }), "first", "GET"));

            linkslist.Add(new LinkDto(_urlHelper.Link(nameof(GetAllAccounts), new
            {
                pagecount = queryParameters.PageCount,
                page = queryParameters.GetTotalPages(totalCount),
                orderby = queryParameters.OrderBy
            }), "last", "GET"));

            if (queryParameters.HasNext(totalCount))
            {
                linkslist.Add(new LinkDto(_urlHelper.Link(nameof(GetAllAccounts), new
                {
                    pagecount = queryParameters.PageCount,
                    page = queryParameters.Page + 1,
                    orderby = queryParameters.OrderBy
                }), "next", "GET"));
            }

            if (queryParameters.HasPrevious())
            {
                linkslist.Add(new LinkDto(_urlHelper.Link(nameof(GetAllAccounts), new
                {
                    pagecount = queryParameters.PageCount,
                    page = queryParameters.Page - 1,
                    orderby = queryParameters.OrderBy
                }), "previous", "GET"));
            }

            var posturl = _urlHelper.Link(nameof(AddAccount), new { version = version.ToString() });

            linkslist.Add(
               new LinkDto(posturl,
               "create_account",
               "POST"));

            return linkslist;
        }

        private dynamic ExpandSingleAccountItemAsync(AccountEntity accountItem, ApiVersion version)
        {
            var links = GetLinks(accountItem.Id, version);
            AccountDto item = _mapper.Map<AccountDto>(accountItem);
            if (!string.IsNullOrEmpty(_fakeAddress))
            {
                item.AccountAddress = _fakeAddress;
            }

            var itemToReturn = item.ToDynamic() as IDictionary<string, object>;
            itemToReturn.Add("linkslist", links);

            return itemToReturn;
        }

        private IEnumerable<LinkDto> GetLinks(int id, ApiVersion version)
        {
            var links = new List<LinkDto>();

            var getLink = _urlHelper.Link(nameof(GetSingleAccount), new { version = version.ToString(), id = id });

            links.Add(
              new LinkDto(getLink, "self", "GET"));

            var deleteLink = _urlHelper.Link(nameof(RemoveAccount), new { version = version.ToString(), id = id });

            links.Add(
              new LinkDto(deleteLink,
              "delete_account",
              "DELETE"));

            var createLink = _urlHelper.Link(nameof(AddAccount), new { version = version.ToString() });

            links.Add(
              new LinkDto(createLink,
              "create_account",
              "POST"));

            var updateLink = _urlHelper.Link(nameof(UpdateAccount), new { version = version.ToString(), id = id });

            links.Add(
               new LinkDto(updateLink,
               "update_account",
               "PUT"));

            return links;
        }



    }
}
