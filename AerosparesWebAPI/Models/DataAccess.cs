﻿using System;
using System.Collections.Generic;
using System.Linq;
using Aerospares.WebTicker;


namespace Aerospares.WebTicker
{
    public class DataAccess
    {
        const string CLASSID = "DataAccess";

        public IEnumerable<Shipping> GetShippingFeeds()
        {
            const string MethodName = "GetShippingFeeds()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from f in dc.SM_DETAIL
                                where (f.SM_HEADER.SM_STATUS.DESCRIPTION != "SHIPPED")
                                orderby f.SM_HEADER.SM_NUMBER
                                select new Shipping
                                {

                                    ShipNumber = f.SM_HEADER.SM_NUMBER,
                                    Status = f.SM_HEADER.SM_STATUS.STATUS_CODE,
                                    Date = f.SM_HEADER.ENTRY_DATE.Value,
                                    SO = f.SM_HEADER.SO_HEADER.SO_NUMBER,
                                    PO = f.SM_HEADER.PO_HEADER.PO_NUMBER,
                                    RO = f.SM_HEADER.RO_HEADER.RO_NUMBER,
                                    Priority = (f.SM_HEADER.SO_HEADER != null) ? f.SM_HEADER.SO_HEADER.PRIORITY.Value :
                                    (f.SM_HEADER.PO_HEADER != null) ? f.SM_HEADER.PO_HEADER.PRIORITY.Value :
                                    (f.SM_HEADER.RO_HEADER != null) ? f.SM_HEADER.RO_HEADER.SHIP_PRIORITY.Value : 0,

                                    PartNumber = f.PARTS_MASTER.PN,
                                    IsHazmat = f.PARTS_MASTER.HAZARD_MATERIAL,

                                    Customer = f.SM_HEADER.COMPANy1.COMPANY_NAME
                                };

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<Shipping> GetWarehouseShipmentsAndRepairsOrders()
        {
            const string MethodName = "GetWarehouseShipmentsAndRepairsOrders()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {


                    //var test = (from f in dc.SM_HEADER
                    //           where (f.SM_STATUS.STATUS_CODE != "SHIPPED" )
                    //           orderby f.SM_NUMBER descending

                    //           select new Shipping
                    //           {
                    //               ShipNumber = f.SM_NUMBER,
                    //               Status = f.SM_STATUS.STATUS_CODE,
                    //               Date = f.DATE_CREATED.Value,
                    //               SO = f.SO_HEADER.SO_NUMBER,
                    //               PO = f.PO_HEADER.PO_NUMBER,
                    //               RO = f.RO_HEADER.RO_NUMBER,
                    //               Priority = (f.SO_HEADER != null) ?  f.SHIP_PRIORITY.HasValue? f.SHIP_PRIORITY.Value : 4
                    //              : (f.PO_HEADER != null) ? f.PO_HEADER.PRIORITY.HasValue? f.PO_HEADER.PRIORITY.Value : 4
                    //              : (f.RO_HEADER != null) ? f.RO_HEADER.SHIP_PRIORITY.HasValue ? f.RO_HEADER.SHIP_PRIORITY.Value : 4
                    //              :4,
                    //               // PartNumber = f.PARTS_MASTER.PN,
                    //               IsHazmat = string.IsNullOrEmpty(f.HAZMAT_NOTES) ? "F" : "T",

                    //               Customer = f.COMPANy1.COMPANY_NAME,

                    //               SalesPerson = (f.SO_HEADER != null) ? f.SO_HEADER.SYS_USERS1.USER_NAME : (f.PO_HEADER != null) ? f.PO_HEADER.SYS_USERS.USER_NAME : (f.RO_HEADER != null) ? f.RO_HEADER.SYS_USERS.USER_NAME : ""
                    //           }).ToList();

                    //var query = from f in dc.SM_HEADER
                    //            where (f.SM_STATUS.STATUS_CODE != "SHIPPED")
                    //            orderby f.SM_NUMBER descending

                    //            select new Shipping
                    //            {
                    //                ShipNumber = f.SM_NUMBER,
                    //                Status = f.SM_STATUS.STATUS_CODE,
                    //                Date = f.DATE_CREATED.Value,
                    //                SO = f.SO_HEADER.SO_NUMBER,
                    //                PO = f.PO_HEADER.PO_NUMBER,
                    //                RO = f.RO_HEADER.RO_NUMBER,
                    //                Priority = (f.SO_HEADER != null) ? f.SHIP_PRIORITY.Value :
                    //                (f.PO_HEADER != null) ? f.PO_HEADER.PRIORITY.Value :
                    //                (f.RO_HEADER != null) ? f.RO_HEADER.SHIP_PRIORITY.Value : 4,
                    //               // PartNumber = f.PARTS_MASTER.PN,
                    //                IsHazmat = string.IsNullOrEmpty(f.HAZMAT_NOTES) ? "F" : "T",

                    //                Customer = f.COMPANy1.COMPANY_NAME,

                    //                SalesPerson = (f.SO_HEADER != null) ? f.SO_HEADER.SYS_USERS1.USER_NAME : (f.PO_HEADER != null) ? f.PO_HEADER.SYS_USERS.USER_NAME : (f.RO_HEADER != null) ?  f.RO_HEADER.SYS_USERS.USER_NAME : ""
                    //            };



                    var query = from f in dc.SM_HEADER
                                where (f.SM_STATUS.STATUS_CODE != "SHIPPED")
                                orderby f.SM_NUMBER descending

                                select new Shipping
                                {
                                    ShipNumber = f.SM_NUMBER,
                                    Status = f.SM_STATUS.STATUS_CODE,
                                    Date = f.DATE_CREATED.Value,
                                    SO = f.SO_HEADER.SO_NUMBER,
                                    PO = f.PO_HEADER.PO_NUMBER,
                                    RO = f.RO_HEADER.RO_NUMBER,
                                    Priority = (f.SO_HEADER != null) ? f.SHIP_PRIORITY.HasValue ? f.SHIP_PRIORITY.Value : 4
                                 : (f.PO_HEADER != null) ? f.PO_HEADER.PRIORITY.HasValue ? f.PO_HEADER.PRIORITY.Value : 4
                                 : (f.RO_HEADER != null) ? f.RO_HEADER.SHIP_PRIORITY.HasValue ? f.RO_HEADER.SHIP_PRIORITY.Value : 4
                                 : 4,
                                    // PartNumber = f.PARTS_MASTER.PN,
                                    IsHazmat = string.IsNullOrEmpty(f.HAZMAT_NOTES) ? "F" : "T",

                                    Customer = f.COMPANy1.COMPANY_NAME,

                                    SalesPerson = (f.SO_HEADER != null) ? f.SO_HEADER.SYS_USERS1.USER_NAME : (f.PO_HEADER != null) ? f.PO_HEADER.SYS_USERS.USER_NAME : (f.RO_HEADER != null) ? f.RO_HEADER.SYS_USERS.USER_NAME : ""
                                };

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }



        public IEnumerable<SalesOrder> GetSalesOrders()
        {
            const string MethodName = "GetSalesOrders()";
            try
           {
                using (QuantumEntities dc = new QuantumEntities())
                {

                    //var tt = (from orderdetail in dc.SO_DETAIL
                    //         where orderdetail.SO_HEADER.DATE_CREATED.Value.Day == DateTime.Now.Day &&
                    //               orderdetail.SO_HEADER.DATE_CREATED.Value.Month == DateTime.Now.Month &&
                    //               orderdetail.SO_HEADER.DATE_CREATED.Value.Year == DateTime.Now.Year && (orderdetail.ROUTE_CODE == "S" || orderdetail.ROUTE_CODE == "E")
                    //         orderby orderdetail.SO_HEADER.DATE_CREATED.Value)
                    DateTime TodaysDate = DateTime.Now.Date;

                    //  DateTime EndDate = DateTime.Now.AddDays(-5);
                    var query = from orderdetail in dc.SO_DETAIL

                                where
                               orderdetail.SO_HEADER.DATE_CREATED.Value >= TodaysDate
                                    //      ( orderdetail.SO_HEADER.DATE_CREATED.Value.Day == TodaysDate.Day &&
                                    //               orderdetail.SO_HEADER.DATE_CREATED.Value.Month == TodaysDate.Month &&
                                    //               orderdetail.SO_HEADER.DATE_CREATED.Value.Year == TodaysDate.Year)
                                    && orderdetail.CUSTOMER_PRICE.HasValue && orderdetail.QTY_ORDERED.HasValue
                                      && (orderdetail.ROUTE_CODE == "S" || orderdetail.ROUTE_CODE == "E")
                                orderby orderdetail.SO_HEADER.DATE_CREATED.Value descending
                                select new SalesOrder

                                {
                                    SalesNumber = orderdetail.SO_HEADER.SO_NUMBER,
                                    Date = orderdetail.SO_HEADER.DATE_CREATED.Value,
                                    Customer = orderdetail.SO_HEADER.COMPANy.COMPANY_NAME,
                                    Description = orderdetail.PARTS_MASTER.DESCRIPTION,
                                    PartNumber = orderdetail.PARTS_MASTER.PN,
                                    Type = orderdetail.ROUTE_DESC,
                                    UnitPrice = orderdetail.CUSTOMER_PRICE.Value,
                                    Currency = orderdetail.SO_HEADER.CURRENCY.CURRENCY_CODE,
                                    Employee = orderdetail.SYS_USERS.EMPLOYEE_CODE
                                    ,
                                    TotalAmount = (orderdetail.QTY_ORDERED.Value * orderdetail.CUSTOMER_PRICE.Value)
                                    ,
                                    Quantity = orderdetail.QTY_ORDERED.Value
                                    ,
                                    Serialized = orderdetail.PARTS_MASTER.SERIALIZED

                                };

                    return query.ToList().Where(o => !o.PartNumber.StartsWith("CORE REPAIR")).Select(o => o).ToList();
                  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<Quote> GetQuoteFeeds()
        {
            const string MethodName = "GetQuoteFeeds()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from quotedetail in dc.CQ_DETAIL
                                where quotedetail.CQ_HEADER.DATE_CREATED.Value.Day == DateTime.Now.Day &&
                                      quotedetail.CQ_HEADER.DATE_CREATED.Value.Month == DateTime.Now.Month &&
                                      quotedetail.CQ_HEADER.DATE_CREATED.Value.Year == DateTime.Now.Year
                                orderby quotedetail.CQ_HEADER.DATE_CREATED.Value descending
                                select new Quote
                                {
                                    QuoteNumber = quotedetail.CQ_HEADER.CQ_NUMBER,
                                    PartNumber = quotedetail.PARTS_MASTER.PN,
                                    Description = quotedetail.PARTS_MASTER.DESCRIPTION,
                                    Date = quotedetail.CQ_HEADER.DATE_CREATED.Value,
                                    Type = quotedetail.ROUTE_DESC,
                                    Currency = quotedetail.CQ_HEADER.CURRENCY.CURRENCY_CODE,
                                    UnitPrice = quotedetail.CUSTOMER_PRICE.Value,
                                    Customer = quotedetail.CQ_HEADER.BILL_NAME,
                                    Employee = quotedetail.SYS_USERS.EMPLOYEE_CODE,
                                    Quantity = quotedetail.QTY_QUOTED.Value,
                                    TotalAmount = (quotedetail.CUSTOMER_PRICE.Value * quotedetail.QTY_QUOTED.Value)
                                };

                    return query.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<PartNumberHit> GetPartNumberHits()
        {
            const string MethodName = "GetPartNumberHits()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = (from quotedetail in dc.CQ_DETAIL
                                 where quotedetail.CQ_HEADER.DATE_CREATED.Value.Day == DateTime.Now.Day &&
                                       quotedetail.CQ_HEADER.DATE_CREATED.Value.Month == DateTime.Now.Month &&
                                       quotedetail.CQ_HEADER.DATE_CREATED.Value.Year == DateTime.Now.Year

                                         && (quotedetail.ROUTE_DESC != "Misc" && quotedetail.ROUTE_DESC != "Freight" && quotedetail.ROUTE_DESC != "Labor")
                                         && quotedetail.PARTS_MASTER.PN != "DOT31FP COMPLIANT BOX"
                                 orderby quotedetail.CQ_HEADER.DATE_CREATED.Value descending
                                 group quotedetail by quotedetail.PARTS_MASTER.PN into grp
                                 where grp.Count() > 2
                                 select new PartNumberHit
                                 {
                                     PartNumber = grp.Key,
                                     Hits = grp.Count()
                                 }).OrderByDescending(y => y.Hits);

                    return query.Take(5).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<GoodRecevied> GetGRNFeeds()
        {
            const string MethodName = "GetGRNFeeds()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from rcd in dc.RC_DETAIL
                                where rcd.RC_HEADER.OPEN_FLAG == "T"
                                select new GoodRecevied
                                {
                                    GRN = rcd.RC_HEADER.RC_NUMBER,
                                    Description = rcd.PARTS_MASTER.DESCRIPTION,
                                    Date = rcd.RC_HEADER.ENTRY_DATE.Value,
                                    OrderType = rcd.RC_HEADER.ORDER_TYPE1,
                                    OrderNumber = rcd.RC_HEADER.ORDER_NUMBER1,
                                    SerialNumber = (rcd.SERIALIZED == "T") ? rcd.RC_SERIAL.FirstOrDefault().SERIAL_NUMBER : " ",
                                    PartNumber = rcd.PARTS_MASTER.PN,
                                    Qty = rcd.QTY.Value,
                                    Customer = rcd.RC_HEADER.COMPANY_NAME

                                };
                    ////////////////////////////////////////////////////////////////////////////////////////////////
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<PartNumberHit> GetPartNumber30DayHits()
        {
            const string MethodName = "GetPartNumber30DayHits()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    DateTime StartDate = DateTime.Now.AddDays(-30);
                    DateTime EndDate = DateTime.Now;
                    var query = (from quotedetail in dc.CQ_DETAIL
                                 where
                                 (quotedetail.CQ_HEADER.DATE_CREATED.Value >= StartDate && quotedetail.CQ_HEADER.DATE_CREATED.Value <= EndDate)
                                  && (quotedetail.ROUTE_DESC != "Misc" && quotedetail.ROUTE_DESC != "Freight" && quotedetail.ROUTE_DESC != "Labor")
                                  && quotedetail.PARTS_MASTER.PN != "DOT31FP COMPLIANT BOX"
                                 orderby quotedetail.CQ_HEADER.DATE_CREATED.Value descending
                                 group quotedetail by quotedetail.PARTS_MASTER.PN into grp
                                 where grp.Count() > 2
                                 select new PartNumberHit
                                 {
                                     PartNumber = grp.Key,
                                     Hits = grp.Count()
                                 }).OrderByDescending(y => y.Hits);

                    return query.Take(20).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<EmployeeSales> GetTotalEmployeeSales()
        {
            const string MethodName = "GetTotalEmployeeSales()";
            try
            {
                var TodaySalesOrders = this.GetSalesOrders();

                var query = from orders in TodaySalesOrders
                            group orders by orders.Employee into grp
                            select new EmployeeSales
                            {
                                Employeee = grp.Key,
                                SalesCount = grp.Select(o => o.SalesNumber).Distinct().Count(),
                                TotalSalesUnitPrice = grp.Sum(o => o.TotalAmount)
                            };

                return query.OrderByDescending(o => o.SalesCount).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<EmployeeQuotes> GetTotalEmployeeQuotes()
        {
            const string MethodName = "GetTotalEmployeeQuotes()";

            try
            {
                var TodayQuotes = this.GetQuoteFeeds();

                var query = from quotes in TodayQuotes
                            group quotes by quotes.Employee into grp
                            select new EmployeeQuotes
                             {
                                 Employeee = grp.Key,
                                 QuotesCount = grp.Select(o => o.QuoteNumber).Distinct().Count(),
                                 TotalQuotesUnitPrice = grp.Sum(o => o.TotalAmount)
                             };
                return query.OrderByDescending(o => o.QuotesCount).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }


        public IEnumerable<RepairOrder> GetRepairOrders()
        {
            const string MethodName = "GetRepairOrders()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from rodetail in dc.RO_DETAIL
                                //join sodetail in dc.SO_DETAIL on rodetail.ROD_AUTO_KEY equals sodetail.ROD_AUTO_KEY into rsdetail
                                where
                                rodetail.RO_HEADER.OPEN_FLAG == "T"

                                orderby rodetail.RO_HEADER.ENTRY_DATE ascending
                                //from sd in rsdetail.DefaultIfEmpty()
                                select new
                                {
                                    RoDetail = rodetail

                                }
                              ;

                    var tt = query.Select(rsdetail => new RepairOrder
                                {
                                    ComapanyName = rsdetail.RoDetail.RO_HEADER.VENDOR_NAME
                                     ,
                                    RONumber = rsdetail.RoDetail.RO_HEADER.RO_NUMBER
                                     ,
                                    EntryDate = rsdetail.RoDetail.RO_HEADER.ENTRY_DATE
                                     ,
                                    PartNumber = rsdetail.RoDetail.PARTS_MASTER.PN
                                     ,
                                    SONumber = rsdetail.RoDetail.SO_DETAIL1.SO_HEADER.SO_NUMBER
                                    ,
                                    Status = rsdetail.RoDetail.SDF_ROD_010
                                    ,

                                    // AS DISCUSSED RO_UDF_002 IS SENT TO CUSTOMER
                                    UDF002 = rsdetail.RoDetail.RO_UDF_002
                                        // AS DISCUSSED RO_UDF_003 RO APPROVED DATE
                                    ,
                                    UDF003 = rsdetail.RoDetail.RO_UDF_003

                                }).ToList();
                    ;

                    return tt;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public DateTime FirstDayOfMonth(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public DateTime LastDayOfMonth(DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        public DateTime Last12MonthsDate(DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            return firstDayOfTheMonth.AddMonths(-12).AddDays(-1);
        }

        public DateTime YTDDate(DateTime dateTime)
        {
            DateTime YTDDate = new DateTime(dateTime.Year, 1, 1);
            // DateTime lastDay = new DateTime(year, 12, 31);
            return YTDDate;
        }

        public DateTime Last3MonthsDate(DateTime dateTime)
        {
            DateTime last3MonthsDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            return last3MonthsDate.AddMonths(-3).AddDays(-1);
        }


        //Current Quater
        public int GetQuarterName(DateTime myDate)
        {
            return (int)Math.Ceiling(myDate.Month / 3.0);
        }

        public DateTime GetQuarterStartingDate(DateTime myDate)
        {
            return new DateTime(myDate.Year, (3 * GetQuarterName(myDate)) - 2, 1);
        }
        public DateTime GetQuarterEndDate(DateTime myDate)
        {
            return new DateTime(myDate.Year, (3 * GetQuarterName(myDate)), 1).AddMonths(1).AddDays(-1);
        }


        //public static void Main(string[] args)
        //{

        //    var mydate = Convert.ToDateTime("1-12-2020");
        //    //var mydate = DateTime.Now;
        //    Console.WriteLine(Math.Ceiling(mydate.Month / 3m));
        //    Console.WriteLine(GetQuarterStartingDate(mydate));
        //    Console.WriteLine(GetQuarterEndDate(mydate));

        //}

        public IEnumerable<EmployeeSales> GetEmployeeMTDSalesOrders()
        {
            const string MethodName = "GetEmployeeMTDSalesOrders()";
            try
            {
                DateTime StartDate = FirstDayOfMonth(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from orderdetail in dc.SO_DETAIL
                                where (orderdetail.SO_HEADER.DATE_CREATED.Value >= StartDate && orderdetail.SO_HEADER.DATE_CREATED.Value <= EndDate)


                                //select new EmployeeSales
                                //{
                                //    Employeee = grp.Key,
                                //    SalesCount = grp.Select(o=> o.SO_HEADER.SO_NUMBER).Distinct().Count(),
                                //    TotalSalesUnitPrice = grp.Sum(o => o.QTY_ORDERED.Value * o.CUSTOMER_PRICE.Value)
                                //};

                                select new SalesOrder

                                {
                                    SalesNumber = orderdetail.SO_HEADER.SO_NUMBER,
                                    Date = orderdetail.SO_HEADER.DATE_CREATED.Value,
                                    Customer = orderdetail.SO_HEADER.COMPANy.COMPANY_NAME,
                                    Description = orderdetail.PARTS_MASTER.DESCRIPTION,
                                    PartNumber = orderdetail.PARTS_MASTER.PN,
                                    Type = orderdetail.ROUTE_DESC,
                                    UnitPrice = orderdetail.CUSTOMER_PRICE.HasValue ? orderdetail.CUSTOMER_PRICE.Value : 0,
                                    Currency = orderdetail.SO_HEADER.CURRENCY.CURRENCY_CODE,
                                    Employee = orderdetail.SO_HEADER.SYS_USERS1.EMPLOYEE_CODE
                                    ,
                                    TotalAmount = (orderdetail.QTY_ORDERED.Value * (orderdetail.CUSTOMER_PRICE.HasValue ? orderdetail.CUSTOMER_PRICE.Value : 0))
                                    ,
                                    Quantity = orderdetail.QTY_ORDERED.Value

                                };



                    var temp = from d in query.ToList()
                               group d by d.Employee into grp
                               select new EmployeeSales
                                  {
                                      Employeee = grp.Key,
                                      SalesCount = grp.Select(o => o.SalesNumber).Distinct().Count(),
                                      TotalSalesUnitPrice = grp.Sum(o => o.TotalAmount)
                                  };

                    return temp.OrderByDescending(o => o.SalesCount).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<EmployeeQuotes> GetEmployeeMTDQuotes()
        {
            const string MethodName = "GetEmployeeMTDQuotes()";
            try
            {
                DateTime StartDate = FirstDayOfMonth(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from quotedetail in dc.CQ_DETAIL
                                where (quotedetail.CQ_HEADER.DATE_CREATED.Value >= StartDate && quotedetail.CQ_HEADER.DATE_CREATED.Value <= EndDate)

                                // group quotedetail by quotedetail.CQ_HEADER.SYS_USERS.EMPLOYEE_CODE into grp

                                select new Quote
                                 {
                                     QuoteNumber = quotedetail.CQ_HEADER.CQ_NUMBER,
                                     PartNumber = quotedetail.PARTS_MASTER.PN,
                                     Description = quotedetail.PARTS_MASTER.DESCRIPTION,
                                     Date = quotedetail.CQ_HEADER.DATE_CREATED.Value,
                                     Type = quotedetail.ROUTE_DESC,
                                     Currency = quotedetail.CQ_HEADER.CURRENCY.CURRENCY_CODE,
                                     UnitPrice = quotedetail.CUSTOMER_PRICE.Value,
                                     Customer = quotedetail.CQ_HEADER.BILL_NAME,
                                     Employee = quotedetail.SYS_USERS.EMPLOYEE_CODE,
                                     Quantity = quotedetail.QTY_QUOTED.Value,
                                     TotalAmount = (quotedetail.CUSTOMER_PRICE.Value * quotedetail.QTY_QUOTED.Value)
                                 };

                    //select new EmployeeQuotes
                    //{
                    //    Employeee = grp.Key,
                    //    QuotesCount = grp.Select(o => o.CQ_HEADER.CQ_NUMBER).Distinct().Count(),
                    //    TotalQuotesUnitPrice = grp.Sum(o => o.CUSTOMER_PRICE.Value * o.QTY_QUOTED.Value)
                    //};


                    var temp = from d in query.ToList()
                               group d by d.Employee into grp
                               select new EmployeeQuotes
                               {
                                   Employeee = grp.Key,
                                   QuotesCount = grp.Select(o => o.QuoteNumber).Distinct().Count(),
                                   TotalQuotesUnitPrice = grp.Sum(o => o.TotalAmount)
                               };

                    return temp.OrderByDescending(o => o.QuotesCount).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        #region

        public decimal GetInvoiceTodayTotals()
        {
            const string MethodName = "GetInvoiceTodayTotals()";
            try
            {
                DateTime TodayDate = DateTime.Now;


                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from invoiceheader in dc.INVC_HEADER
                                where (
                                (
                                    invoiceheader.INVOICE_DATE.Day == TodayDate.Day
                                   && invoiceheader.INVOICE_DATE.Month == TodayDate.Month
                                   && invoiceheader.INVOICE_DATE.Year == TodayDate.Year
                                )
                                && invoiceheader.POST_STATUS == 3
                                && (invoiceheader.INVC_TYPE == "I" || invoiceheader.INVC_TYPE == "M"))
                                select new
                                {
                                    invoiceheader.FOREIGN_AMOUNT
                                };

                    var invoicemtdtotal = query.Sum(o => o.FOREIGN_AMOUNT);
                    if (invoicemtdtotal.HasValue)
                        return Math.Round(invoicemtdtotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }
        public decimal GetInvoiceMTDTotals()
        {
            const string MethodName = "GetInvoiceMTDTotals()";
            try
            {
                DateTime StartDate = FirstDayOfMonth(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from invoiceheader in dc.INVC_HEADER
                                where (
                                (invoiceheader.INVOICE_DATE >= StartDate && invoiceheader.INVOICE_DATE <= EndDate)
                                && invoiceheader.POST_STATUS == 3
                                && (invoiceheader.INVC_TYPE == "I" || invoiceheader.INVC_TYPE == "M"))
                                select new
                                {
                                    invoiceheader.FOREIGN_AMOUNT
                                };

                    var invoicemtdtotal = query.Sum(o => o.FOREIGN_AMOUNT);
                    if (invoicemtdtotal.HasValue)
                        return Math.Round(invoicemtdtotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }
        public decimal GetYTDInvoiceTotals()
        {
            const string MethodName = "GetYTDInvoiceTotals()";
            try
            {
                DateTime StartDate = YTDDate(DateTime.Now);
                DateTime EndDate = DateTime.Now;

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from invoiceheader in dc.INVC_HEADER
                                where (
                                (invoiceheader.INVOICE_DATE >= StartDate && invoiceheader.INVOICE_DATE <= EndDate)
                                && invoiceheader.POST_STATUS == 3
                                && (invoiceheader.INVC_TYPE == "I" || invoiceheader.INVC_TYPE == "M"))
                                select new
                                {
                                    invoiceheader.FOREIGN_AMOUNT
                                };

                    var invoiceytdtotal = query.Sum(o => o.FOREIGN_AMOUNT);
                    if (invoiceytdtotal.HasValue)
                        return Math.Round(invoiceytdtotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetQTDInvoiceTotals()
        {
            const string MethodName = "GetQTDInvoiceTotals()";
            try
            {
                DateTime StartDate = GetQuarterStartingDate(DateTime.Now);
                DateTime EndDate = GetQuarterEndDate(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from invoiceheader in dc.INVC_HEADER
                                where (
                                (invoiceheader.INVOICE_DATE >= StartDate && invoiceheader.INVOICE_DATE <= EndDate)
                                && invoiceheader.POST_STATUS == 3
                                && (invoiceheader.INVC_TYPE == "I" || invoiceheader.INVC_TYPE == "M"))
                                select new
                                {
                                    invoiceheader.FOREIGN_AMOUNT
                                };

                    var invoiceytdtotal = query.Sum(o => o.FOREIGN_AMOUNT);
                    if (invoiceytdtotal.HasValue)
                        return Math.Round(invoiceytdtotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetLTMInvoiceTotals()
        {
            const string MethodName = "GetLTMInvoiceTotals()";
            try
            {
                DateTime StartDate = Last12MonthsDate(DateTime.Now);
                DateTime EndDate = DateTime.Now;

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from invoiceheader in dc.INVC_HEADER
                                where (
                                (invoiceheader.INVOICE_DATE >= StartDate && invoiceheader.INVOICE_DATE <= EndDate)
                                && invoiceheader.POST_STATUS == 3
                                && (invoiceheader.INVC_TYPE == "I" || invoiceheader.INVC_TYPE == "M"))
                                select new
                                {
                                    invoiceheader.FOREIGN_AMOUNT
                                };

                    var invoiceytdtotal = query.Sum(o => o.FOREIGN_AMOUNT);
                    if (invoiceytdtotal.HasValue)
                        return Math.Round(invoiceytdtotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        #endregion

        public decimal GetYTDSalesTotals()
        {
            const string MethodName = "GetYTDSalesTotals()";
            try
            {
                DateTime StartDate = YTDDate(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from orderdetail in dc.SO_DETAIL
                                where (orderdetail.SO_HEADER.DATE_CREATED.Value >= StartDate && orderdetail.SO_HEADER.DATE_CREATED.Value <= EndDate)


                                //select new EmployeeSales
                                //{
                                //    Employeee = grp.Key,
                                //    SalesCount = grp.Select(o=> o.SO_HEADER.SO_NUMBER).Distinct().Count(),
                                //    TotalSalesUnitPrice = grp.Sum(o => o.QTY_ORDERED.Value * o.CUSTOMER_PRICE.Value)
                                //};

                                select new

                                {

                                    SalesAmount = (orderdetail.QTY_ORDERED.Value * (orderdetail.CUSTOMER_PRICE.HasValue ? orderdetail.CUSTOMER_PRICE.Value : 0))


                                };


                    var salesytdtotal = query.Sum(o => o.SalesAmount);
                    if (salesytdtotal > 0)
                        return Math.Round(salesytdtotal, 0);
                    else return 0;


                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetQTDSalesTotals()
        {
            const string MethodName = "GetQTDSalesTotals";
            try
            {
                DateTime StartDate = GetQuarterStartingDate(DateTime.Now);
                DateTime EndDate = GetQuarterEndDate(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from orderdetail in dc.SO_DETAIL
                                where (orderdetail.SO_HEADER.DATE_CREATED.Value >= StartDate && orderdetail.SO_HEADER.DATE_CREATED.Value <= EndDate)


                                //select new EmployeeSales
                                //{
                                //    Employeee = grp.Key,
                                //    SalesCount = grp.Select(o=> o.SO_HEADER.SO_NUMBER).Distinct().Count(),
                                //    TotalSalesUnitPrice = grp.Sum(o => o.QTY_ORDERED.Value * o.CUSTOMER_PRICE.Value)
                                //};

                                select new

                                {

                                    SalesAmount = (orderdetail.QTY_ORDERED.Value * (orderdetail.CUSTOMER_PRICE.HasValue ? orderdetail.CUSTOMER_PRICE.Value : 0))


                                };


                    var salesytdtotal = query.Sum(o => o.SalesAmount);
                    if (salesytdtotal > 0)
                        return Math.Round(salesytdtotal, 0);
                    else return 0;


                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetLTMSalesTotals()
        {
            const string MethodName = "GetLTMSalesTotals";
            try
            {
                DateTime StartDate = Last12MonthsDate(DateTime.Now);
                DateTime EndDate = DateTime.Now;

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from orderdetail in dc.SO_DETAIL
                                where (orderdetail.SO_HEADER.DATE_CREATED.Value >= StartDate && orderdetail.SO_HEADER.DATE_CREATED.Value <= EndDate)


                                //select new EmployeeSales
                                //{
                                //    Employeee = grp.Key,
                                //    SalesCount = grp.Select(o=> o.SO_HEADER.SO_NUMBER).Distinct().Count(),
                                //    TotalSalesUnitPrice = grp.Sum(o => o.QTY_ORDERED.Value * o.CUSTOMER_PRICE.Value)
                                //};

                                select new

                                {

                                    SalesAmount = (orderdetail.QTY_ORDERED.Value * (orderdetail.CUSTOMER_PRICE.HasValue ? orderdetail.CUSTOMER_PRICE.Value : 0))


                                };


                    var salesytdtotal = query.Sum(o => o.SalesAmount);
                    if (salesytdtotal > 0)
                        return Math.Round(salesytdtotal, 0);
                    else return 0;


                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetYTDQuotesTotals(DateTime StartDate, DateTime EndDate)
        {
            const string MethodName = "GetYTDQuotes()";
            try
            {
                //  DateTime StartDate = Last12MonthsDate(DateTime.Now);
                //  DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from quotedetail in dc.CQ_DETAIL
                                where (quotedetail.CQ_HEADER.DATE_CREATED.Value >= StartDate && quotedetail.CQ_HEADER.DATE_CREATED.Value <= EndDate)
                                select new
                                {
                                    QuoteAmount = (quotedetail.CUSTOMER_PRICE.Value * quotedetail.QTY_QUOTED.Value)
                                };


                    var quoteytdtotal = query.Sum(o => o.QuoteAmount);
                    if (quoteytdtotal > 0)
                        return Math.Round(quoteytdtotal, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }




        #region Purchase Order Totals

        public decimal GetPurchaseOrderTodayTotals()
        {
            const string MethodName = "GetPurchaseOrderTodayTotals()";
            try
            {
                DateTime TodayDate = DateTime.Now;
                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from po in dc.PO_HEADER
                                where 
                                (
                                    po.ENTRY_DATE.Day == TodayDate.Day
                                   && po.ENTRY_DATE.Month == TodayDate.Month
                                   && po.ENTRY_DATE.Year == TodayDate.Year
                                )
                    select new
                    {
                        TotalCost = po.TOTAL_COST
                    };
                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetPurchaseOrderMTDTotals()
        {
            const string MethodName = "GetPurchaseOrderMTDTotals()";
            try
            {
                DateTime StartDate = FirstDayOfMonth(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from po in dc.PO_HEADER  where (po.ENTRY_DATE >= StartDate && po.ENTRY_DATE <= EndDate)
                                select new{
                                    TotalCost = po.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetPurchaseOrderYTDTotals()
        {
            const string MethodName = "GetPurchaseOrderYTDTotals()";
            try
            {
                DateTime StartDate = YTDDate(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from po in dc.PO_HEADER
                                where (po.ENTRY_DATE >= StartDate && po.ENTRY_DATE <= EndDate)
                                select new
                                {
                                    TotalCost = po.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetPurchaseOrderQTDTotals()
        {
            const string MethodName = "GetPurchaseOrderQTDTotals()";
            try
            {
                DateTime StartDate = GetQuarterStartingDate(DateTime.Now);
                DateTime EndDate = GetQuarterEndDate(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from po in dc.PO_HEADER
                                where (po.ENTRY_DATE >= StartDate && po.ENTRY_DATE <= EndDate)
                                select new
                                {
                                    TotalCost = po.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetPurchaseOrderLTMTotals()
        {
            const string MethodName = "GetPurchaseOrderLTMTotals()";
            try
            {
                DateTime StartDate = Last12MonthsDate(DateTime.Now);
                DateTime EndDate = DateTime.Now;

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from po in dc.PO_HEADER
                                where (po.ENTRY_DATE >= StartDate && po.ENTRY_DATE <= EndDate)
                                select new
                                {
                                    TotalCost = po.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        #endregion

        #region Repair Order Totals
        public decimal GetRepairOrderTodayTotals()
        {
            const string MethodName = "GetPurchaseOrderTodayTotals()";
            try
            {
                DateTime TodayDate = DateTime.Now;
                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from ro in dc.RO_HEADER
                                where
                                (
                                    ro.ENTRY_DATE.Day == TodayDate.Day
                                   && ro.ENTRY_DATE.Month == TodayDate.Month
                                   && ro.ENTRY_DATE.Year == TodayDate.Year
                                )
                                select new
                                {
                                    TotalCost = ro.TOTAL_COST
                                };
                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetRepairOrderMTDTotals()
        {
            const string MethodName = "GetRepairOrderMTDTotals()";
            try
            {
                DateTime StartDate = FirstDayOfMonth(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from ro in dc.RO_HEADER
                                where (ro.ENTRY_DATE >= StartDate && ro.ENTRY_DATE <= EndDate)
                                select new
                                {
                                    TotalCost = ro.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetRepairOrderYTDTotals()
        {
            const string MethodName = "GetRepairOrderYTDTotals()";
            try
            {
                DateTime StartDate = YTDDate(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from ro in dc.RO_HEADER
                                where (ro.ENTRY_DATE >= StartDate && ro.ENTRY_DATE <= EndDate)
                                select new
                                {
                                    TotalCost = ro.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetRepairOrderQTDTotals()
        {
            const string MethodName = "GetRepairOrderQTDTotals()";
            try
            {
                DateTime StartDate = GetQuarterStartingDate(DateTime.Now);
                DateTime EndDate = GetQuarterEndDate(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from ro in dc.RO_HEADER
                                where (ro.ENTRY_DATE >= StartDate && ro.ENTRY_DATE <= EndDate)
                                select new
                                {
                                    TotalCost = ro.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public decimal GetRepairOrderLTMTotals()
        {
            const string MethodName = "GetRepairOrderLTMTotals()";
            try
            {
                DateTime StartDate = Last12MonthsDate(DateTime.Now);
                DateTime EndDate = DateTime.Now;

                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from ro in dc.RO_HEADER
                                where (ro.ENTRY_DATE >= StartDate && ro.ENTRY_DATE <= EndDate)
                                select new
                                {
                                    TotalCost = ro.TOTAL_COST
                                };

                    var potodaytotal = query.Sum(o => o.TotalCost);
                    if (potodaytotal.HasValue)
                        return Math.Round(potodaytotal.Value, 0);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        #endregion


        public int GetSalesCount(DateTime StartDate, DateTime EndDate)
        {
            const string MethodName = "GetSalesCount()";
            try
            {
                //  DateTime StartDate = Last12MonthsDate(DateTime.Now);
                //  DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from salesOrder in dc.SO_HEADER
                                where (salesOrder.DATE_CREATED.Value >= StartDate && salesOrder.DATE_CREATED.Value <= EndDate)
                                select salesOrder;
                    var salesytdCount = query.Count();
                    if (salesytdCount > 0)
                        return salesytdCount;
                    else return 0;


                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public int GetQuotesCount(DateTime StartDate, DateTime EndDate)
        {
            const string MethodName = "GetQuotesCount()";
            try
            {
                // DateTime StartDate = Last12MonthsDate(DateTime.Now);
                // DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from quoteHeader in dc.CQ_HEADER
                                where (quoteHeader.DATE_CREATED.Value >= StartDate && quoteHeader.DATE_CREATED.Value <= EndDate)
                                select quoteHeader;
                    // no quotes filter need to apply  


                    int quoteytdCount = query.Count();
                    if (quoteytdCount > 0)
                        return quoteytdCount;
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public SaleOrderToQuoteRatio GetSaleOrderToQuoteRatios()
        {
            const string MethodName = "GetSaleOrderToQuoteRatios()";
            try
            {
                DateTime TodaysDate = DateTime.Now;
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                int TodaySales = GetSalesCount(TodaysDate.Date, TodaysDate);
                int MTDSales = GetSalesCount(FirstDayOfMonth(TodaysDate), TodaysDate);
                int YTDSales = GetSalesCount(YTDDate(TodaysDate), TodaysDate);
                int QTDSales = GetSalesCount(GetQuarterStartingDate(TodaysDate), GetQuarterEndDate(TodaysDate));
                int LTMSales = GetSalesCount(Last12MonthsDate(TodaysDate), TodaysDate);

                int TodayQuotes = GetQuotesCount(TodaysDate.Date, TodaysDate);
                int MTDQuotes = GetQuotesCount(FirstDayOfMonth(TodaysDate), TodaysDate);
                int YTDQuotes = GetQuotesCount(YTDDate(TodaysDate), TodaysDate);
                int QTDQuotes = GetQuotesCount(GetQuarterStartingDate(TodaysDate), GetQuarterEndDate(TodaysDate));
                int LTMQuotes = GetQuotesCount(Last12MonthsDate(TodaysDate), TodaysDate);

                double TodayOTQRatio = (TodaySales > 0 && TodayQuotes > 0) ? Math.Round((((double)TodaySales / TodayQuotes) * 100), 2) : (double)0;
                double MTDOTQRatio = (MTDSales > 0 && MTDQuotes > 0) ? Math.Round((((double)MTDSales / MTDQuotes) * 100), 2) : (double)0;
                double YTDOTQRatio = (YTDSales > 0 && YTDQuotes > 0) ? Math.Round((((double)YTDSales / YTDQuotes) * 100), 2) : (double)0;
                double QTDOTQRatio = (QTDSales > 0 && QTDQuotes > 0) ? Math.Round((((double)QTDSales / QTDQuotes) * 100), 2) : (double)0;
                double LTMOTQRatio = (LTMSales > 0 && LTMQuotes > 0) ? Math.Round((((double)LTMSales / LTMQuotes) * 100), 2) : (double)0;

                return new SaleOrderToQuoteRatio() { TodayOrderToQuoteRatio = TodayOTQRatio, MTDOrderToQuoteRatio = MTDOTQRatio, YTDOrderToQuoteRatio = YTDOTQRatio , QTDOrderToQuoteRatio = QTDOTQRatio, LTMOrderToQuoteRatio = LTMOTQRatio};
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }


        public PurchaseOrderTotals GetPurchaseOrderTotals()
        {
            const string MethodName = "GetPurchaseOrderTotals()";
            try
            {
                DateTime TodaysDate = DateTime.Now;
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                decimal TodayPO = GetPurchaseOrderTodayTotals();
                decimal MTDPO = GetPurchaseOrderMTDTotals();
                decimal YTDPO = GetPurchaseOrderYTDTotals();
                decimal QTDPO = GetPurchaseOrderQTDTotals();
                decimal LTMPO = GetPurchaseOrderLTMTotals();

                return new PurchaseOrderTotals() {  TodayPurchaseOrder = TodayPO, MTDPurchaseOrder = MTDPO, YTDPurchaseOrder = YTDPO , QTDPurchaseOrder = QTDPO, LTMPurchaseOrder = LTMPO};
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public RepairOrderTotals GetRepairOrderTotals()
        {
            const string MethodName = "GetRepairOrderTotals()";
            try
            {
                DateTime TodaysDate = DateTime.Now;
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                decimal TodayRO = GetRepairOrderTodayTotals();
                decimal MTDRO = GetRepairOrderMTDTotals();
                decimal YTDRO = GetRepairOrderYTDTotals();
                decimal QTDRO = GetRepairOrderQTDTotals();
                decimal LTMRO = GetRepairOrderLTMTotals();

                return new RepairOrderTotals() { TodayRepairOrder = TodayRO, MTDRepairOrder = MTDRO, YTDRepairOrder = YTDRO, QTDRepairOrder = QTDRO, LTMRepairOrder= LTMRO };
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }


        #region Methods for New Screen Slaes/Customer Type
        public IEnumerable<SalesByCustomerType> GetSalesByCustomerType(DateTime StartDate, DateTime EndDate)
        {
            const string MethodName = "GetSalesByCustomerType()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {


                    DateTime TodaysDate = StartDate;

                    //  DateTime EndDate = DateTime.Now.AddDays(-5);
                    //var query = from orderdetail in dc.SO_DETAIL

                    //            where
                    //           orderdetail.SO_HEADER.DATE_CREATED.Value >= TodaysDate
                    //                  //      ( orderdetail.SO_HEADER.DATE_CREATED.Value.Day == TodaysDate.Day &&
                    //                  //               orderdetail.SO_HEADER.DATE_CREATED.Value.Month == TodaysDate.Month &&
                    //                  //               orderdetail.SO_HEADER.DATE_CREATED.Value.Year == TodaysDate.Year)

                    //                  && (orderdetail.ROUTE_CODE == "S" || orderdetail.ROUTE_CODE == "E")
                    //            orderby orderdetail.SO_HEADER.DATE_CREATED.Value descending


                    //  (orderdetail.QTY_ORDERED.Value * orderdetail.CUSTOMER_PRICE.Value)

                    var query = from salesOrder in dc.SO_HEADER
                                where (salesOrder.DATE_CREATED.Value >= StartDate && salesOrder.DATE_CREATED.Value <= EndDate)
                                // where salesOrder.SO_NUMBER =="S15411"

                                select new SalesByCustomerType

                                {
                                    SalesNumber = salesOrder.SO_NUMBER,
                                    Date = salesOrder.DATE_CREATED.Value,
                                    CompanyName = salesOrder.COMPANy.COMPANY_NAME
                                    ,
                                    TotalCost = salesOrder.TOTAL_COST

                                     ,
                                    TotalPrice = salesOrder.TOTAL_PRICE
                                    ,
                                    Customer = salesOrder.COMPANy.CUSTOMER_FLAG
                                     ,
                                    Vendor = salesOrder.COMPANy.VENDOR_FLAG
                                     ,
                                    Airline = salesOrder.COMPANy.CV_UDF_001
                                     ,
                                    MROFBO = salesOrder.COMPANy.CV_UDF_002
                                     ,
                                    BrokerSerious = salesOrder.COMPANy.CV_UDF_003
                                     ,
                                    Broker = salesOrder.COMPANy.CV_UDF_004
                                     ,
                                    OEM = salesOrder.COMPANy.CV_UDF_005
                                     ,
                                    MROAPPD = salesOrder.COMPANy.CV_UDF_006
                                     ,
                                    SUPAPPD = salesOrder.COMPANy.CV_UDF_007

                                };

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<SalesByCustomerTypeStats> GetSalesByCustomerTypeStats(DateTime StartDate, DateTime EndDate)
        {
            const string MethodName = "GetSalesByCustomerTypeStats()";
            try
            {

                var vm = new SalesByCustomerTypeViewModel(this.GetSalesByCustomerType(StartDate, EndDate));
                return vm.GetSalesByCustomerTypeStats();


            }

            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }



        public IEnumerable<SalesByAirCraftType> GetSalesByAirCraftType(DateTime StartDate, DateTime EndDate)
        {
            const string MethodName = "GetSalesByAirCraftType()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {

                    var query = from invdetail in dc.INVC_DETAIL
                                where (invdetail.INVC_HEADER.POST_DATE.HasValue && invdetail.INVC_HEADER.POST_DATE >= StartDate   && invdetail.INVC_HEADER.POST_DATE <= EndDate)

                                select new SalesByAirCraftType
                                {
                                    InvoiceNumber = invdetail.INVC_HEADER.INVC_NUMBER,
                                    PostDate = invdetail.INVC_HEADER.POST_DATE.Value,
                                    Description = invdetail.PARTS_MASTER.DESCRIPTION,
                                    PartNumber = invdetail.PARTS_MASTER.PN,
                                    ChargeType = invdetail.ROUTE_CODE,
                                    UnitPrice = invdetail.QTY_SHIP.HasValue ? invdetail.QTY_SHIP.Value : 0,
                                    TotalAmount = invdetail.QTY_SHIP.HasValue ? (invdetail.QTY_SHIP.Value * invdetail.UNIT_PRICE.Value) : 0,
                                    Quantity = invdetail.QTY_SHIP.HasValue ? invdetail.QTY_SHIP.Value : 0,
                                    ApplicationCode = invdetail.PARTS_MASTER != null ? invdetail.PARTS_MASTER.MASTER_FLAG == "F" ? "CHARGE" : invdetail.PARTS_MASTER.APPLICATION_CODES.APPLICATION_CODE : "",
                                    HasApplicationCode = invdetail.PARTS_MASTER != null && invdetail.PARTS_MASTER.MASTER_FLAG != "F" ? true : false
                                };

                    var filteredList = query.ToList().Where(o => o.HasApplicationCode).Select(o => o).ToList();

                    return filteredList;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }


        public IEnumerable<SalesByAirCraftTypeStats> GetSalesByAirCraftTypeLast3months()
        {
            const string MethodName = "GetSalesByAirCraftTypeLast3months()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    DateTime queryDate = this.Last3MonthsDate(DateTime.Now.Date);
                    //var query = from orderdetail in dc.SO_DETAIL
                    //            where (orderdetail.SO_HEADER.DATE_CREATED.Value >= queryDate)
                    //            && (orderdetail.ROUTE_CODE == "S" || orderdetail.ROUTE_CODE == "E" || orderdetail.ROUTE_CODE == "F" || orderdetail.ROUTE_CODE == "I")
                    //            select new SalesByAirCraftType
                    //            {
                    //                InvoiceNumber = orderdetail.SO_HEADER.SO_NUMBER,
                    //                PostDate = orderdetail.SO_HEADER.DATE_CREATED.Value,

                    //                Description = orderdetail.PARTS_MASTER.DESCRIPTION,
                    //                PartNumber = orderdetail.PARTS_MASTER.PN,
                    //                ChargeType = orderdetail.ROUTE_DESC,
                    //                UnitPrice = orderdetail.CUSTOMER_PRICE.Value,


                    //                TotalAmount = (orderdetail.QTY_ORDERED.Value * orderdetail.CUSTOMER_PRICE.Value)
                    //                ,
                    //                Quantity = orderdetail.QTY_ORDERED.Value
                    //                ,
                    //                ApplicationCode = orderdetail.PARTS_MASTER.APPLICATION_CODES.APPLICATION_CODE

                    //            };

                    ////var filteredList =   query.ToList().Where(o => !o.PartNumber.StartsWith("CORE REPAIR")).Select(o => o).ToList();

                    //// var totalSales = filteredList.Where(o => o.ApplicationCode != "No Application Specified").Sum(o => o.TotalAmount);
                    //var filteredList = query.ToList();//.Where(o => !o.PartNumber.StartsWith("CORE REPAIR")).Select(o => o).ToList();
                    //var totalSales = filteredList.Sum(o => o.TotalAmount);


                    //var result = (from f in filteredList

                    //             group f by f.ApplicationCode into grp
                    //             select new SalesByAirCraftTypeStats
                    //             {
                    //                 AirCraftType = grp.Key,
                    //                   TotalSalesAmount = grp.Sum(o => o.TotalAmount),
                    //                   Percentage = ((double)(grp.Sum(o => o.TotalAmount)/ totalSales)) * 100
                    //                   , ImageName = grp.Key.Replace("/", "").Replace("-", "").Replace(" ","")
                    //             }).OrderByDescending(a => a.TotalSalesAmount).ToList();
                    //return result;

                    var query = from invdetail in dc.INVC_DETAIL
                                where (invdetail.INVC_HEADER.POST_DATE.HasValue && invdetail.INVC_HEADER.POST_DATE >= queryDate)

                                select new SalesByAirCraftType
                                {
                                    InvoiceNumber = invdetail.INVC_HEADER.INVC_NUMBER,
                                    PostDate = invdetail.INVC_HEADER.POST_DATE.Value,
                                    Description = invdetail.PARTS_MASTER.DESCRIPTION,
                                    PartNumber = invdetail.PARTS_MASTER.PN,
                                    ChargeType = invdetail.ROUTE_CODE,
                                    UnitPrice = invdetail.QTY_SHIP.HasValue ? invdetail.QTY_SHIP.Value : 0,
                                    TotalAmount = invdetail.QTY_SHIP.HasValue ? (invdetail.QTY_SHIP.Value * invdetail.UNIT_PRICE.Value) : 0,
                                    Quantity = invdetail.QTY_SHIP.HasValue ? invdetail.QTY_SHIP.Value : 0,
                                    ApplicationCode = invdetail.PARTS_MASTER != null ? invdetail.PARTS_MASTER.MASTER_FLAG == "F" ? "CHARGE" : invdetail.PARTS_MASTER.APPLICATION_CODES.APPLICATION_CODE : "",
                                    HasApplicationCode = invdetail.PARTS_MASTER != null && invdetail.PARTS_MASTER.MASTER_FLAG != "F" ? true : false
                                };

                    var filteredList = query.ToList().Where(o => o.HasApplicationCode).Select(o => o).ToList();
                    var totalSales = filteredList.Sum(o => o.TotalAmount);

                    var result = (from f in filteredList

                                  group f by f.ApplicationCode into grp
                                  select new SalesByAirCraftTypeStats
                                  {
                                      AirCraftType = grp.Key,
                                      TotalSalesAmount = grp.Sum(o => o.TotalAmount),
                                      Percentage = ((double)(grp.Sum(o => o.TotalAmount) / totalSales)) * 100
                                         ,
                                      ImageName = grp.Key.Replace("/", "").Replace("-", "").Replace(" ", "")
                                  }).OrderByDescending(a => a.TotalSalesAmount).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<SalesByAirCraftTypeStats> GetSalesByAirCraftTypeLast12months()
        {
            const string MethodName = "GetSalesByAirCraftTypeLast12months()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    DateTime queryDate = this.YTDDate(DateTime.Now.Date);
                    //var query = from orderdetail in dc.SO_DETAIL
                    //            where (orderdetail.SO_HEADER.ENTRY_DATE >= queryDate) 
                    //            //&& (orderdetail.ROUTE_CODE == "M" )
                    //            select new SalesByAirCraftType
                    //            {
                    //                SalesNumber = orderdetail.SO_HEADER.SO_NUMBER,
                    //                Date = orderdetail.SO_HEADER.DATE_CREATED.Value,
                    //                Customer = orderdetail.SO_HEADER.COMPANy.COMPANY_NAME,
                    //                Description = orderdetail.PARTS_MASTER.DESCRIPTION,
                    //                PartNumber = orderdetail.PARTS_MASTER.PN,
                    //                Type = orderdetail.ROUTE_DESC,
                    //                UnitPrice = orderdetail.CUSTOMER_PRICE.HasValue? orderdetail.CUSTOMER_PRICE.Value : 0,
                    //             //   Currency = orderdetail.SO_HEADER.CURRENCY.CURRENCY_CODE,
                    //              //  Employee = orderdetail.SYS_USERS.EMPLOYEE_CODE
                    //              //  ,
                    //                TotalAmount = orderdetail.QTY_ORDERED.HasValue ? (orderdetail.QTY_ORDERED.Value * orderdetail.CUSTOMER_PRICE.Value) :0
                    //              //  ,
                    //                //Quantity = orderdetail.QTY_ORDERED.Value
                    //                ,
                    //                ApplicationCode = orderdetail.PARTS_MASTER != null ? orderdetail.PARTS_MASTER.APPLICATION_CODES.APPLICATION_CODE : ""

                    //            };

             

                    //var filteredList = query.ToList().Where(o => o.ApplicationCode != "").Select(o => o).ToList();
                    //var totalSales = filteredList.Sum(o => o.TotalAmount);

                    //var result = (from f in filteredList
                                 
                    //              group f by f.ApplicationCode into grp
                    //              select new SalesByAirCraftTypeStats
                    //              {
                    //                  AirCraftType = grp.Key,
                    //                  TotalSalesAmount = grp.Sum(o => o.TotalAmount),
                    //                    Percentage = ((double)(grp.Sum(o => o.TotalAmount) / totalSales)) * 100
                    //                     ,
                    //                  //ImageName = grp.Key.Replace("/", "").Replace("-", "").Replace(" ", "")
                    //              }).OrderByDescending(a => a.TotalSalesAmount).ToList();
                    //return result;



                    var query = from invdetail in dc.INVC_DETAIL
                                where (invdetail.INVC_HEADER.POST_DATE.HasValue && invdetail.INVC_HEADER.POST_DATE >= queryDate)
                               
                                select new SalesByAirCraftType
                                {
                                    InvoiceNumber = invdetail.INVC_HEADER.INVC_NUMBER,
                                    PostDate = invdetail.INVC_HEADER.POST_DATE.Value,
                                    Description = invdetail.PARTS_MASTER.DESCRIPTION,
                                    PartNumber = invdetail.PARTS_MASTER.PN,
                                    ChargeType = invdetail.ROUTE_CODE,
                                    UnitPrice = invdetail.QTY_SHIP.HasValue ? invdetail.QTY_SHIP.Value : 0,
                                    TotalAmount = invdetail.QTY_SHIP.HasValue ? (invdetail.QTY_SHIP.Value * invdetail.UNIT_PRICE.Value) : 0,
                                    Quantity = invdetail.QTY_SHIP.HasValue ? invdetail.QTY_SHIP.Value :0,
                                    ApplicationCode = invdetail.PARTS_MASTER != null ? invdetail.PARTS_MASTER.MASTER_FLAG == "F" ? "CHARGE" : invdetail.PARTS_MASTER.APPLICATION_CODES.APPLICATION_CODE : "",
                                    HasApplicationCode = invdetail.PARTS_MASTER != null && invdetail.PARTS_MASTER.MASTER_FLAG != "F" ? true : false
                                };

                    var filteredList = query.ToList().Where(o => o.HasApplicationCode).Select(o => o).ToList();
                    var totalSales = filteredList.Sum(o => o.TotalAmount);

                    var result = (from f in filteredList

                                  group f by f.ApplicationCode into grp
                                  select new SalesByAirCraftTypeStats
                                  {
                                      AirCraftType = grp.Key,
                                      TotalSalesAmount = grp.Sum(o => o.TotalAmount),
                                      Percentage = ((double)(grp.Sum(o => o.TotalAmount) / totalSales)) * 100
                                         ,
                                      ImageName = grp.Key.Replace("/", "").Replace("-", "").Replace(" ", "")
                                  }).OrderByDescending(a => a.TotalSalesAmount).ToList();
                    return result;



                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        #endregion




        //public static DateTime StartOfDay(this DateTime theDate)
        //{
        //    return theDate.Date;
        //}

        //public static DateTime EndOfDay(this DateTime theDate)
        //{
        //    return theDate.Date.AddDays(1).AddTicks(-1);
        //}




        //********************************** SAMPLE DATA******************************************************//
        #region Sample Data Methods

        public IEnumerable<Shipping> GetShippingFeeds1()
        {
            const string MethodName = "GetShippingFeeds()";
            try
            {
                List<Shipping> query = new List<Shipping>();
                query.Add(new Shipping { Customer = "Abc", Date = DateTime.Now, PartNumber = "23423DFAD", PO = "24534", Priority = 1, ShipNumber = "34534", Status = "COLSED" });

                query.Add(new Shipping { Customer = "Abc", Date = DateTime.Now, PartNumber = "23423DFAD", PO = "24534", Priority = 1, ShipNumber = "34534", Status = "COLSED" });
                query.Add(new Shipping { Customer = "Abc", Date = DateTime.Now, PartNumber = "23423DFAD", PO = "24534", Priority = 1, ShipNumber = "34534", Status = "COLSED" });
                query.Add(new Shipping { Customer = "Abc", Date = DateTime.Now, PartNumber = "23423DFAD", PO = "24534", Priority = 1, ShipNumber = "34534", Status = "COLSED" });
                query.Add(new Shipping { Customer = "Abc", Date = DateTime.Now, PartNumber = "23423DFAD", PO = "24534", Priority = 2, ShipNumber = "34534", Status = "COLSED" });
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<SalesOrder> GetSalesOrders1()
        {
            const string MethodName = "GetSalesOrders()";
            try
            {
                List<SalesOrder> query = new List<SalesOrder>();
                query.Add(new SalesOrder { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 1212 });
                query.Add(new SalesOrder { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 121 });
                query.Add(new SalesOrder { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 1212 });
                query.Add(new SalesOrder { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 121 });
                query.Add(new SalesOrder { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 121 });
                query.Add(new SalesOrder { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 12 });
                query.Add(new SalesOrder { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 12 });
                return query.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<Quote> GetQuoteFeeds1()
        {
            const string MethodName = "GetQuoteFeeds()";
            try
            {
                using (QuantumEntities dc = new QuantumEntities())
                {
                    List<Quote> query = new List<Quote>();
                    query.Add(new Quote { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 5 });
                    query.Add(new Quote { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 5675 });
                    query.Add(new Quote { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 56 });
                    query.Add(new Quote { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 567 });
                    query.Add(new Quote { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 45 });
                    query.Add(new Quote { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 454 });
                    query.Add(new Quote { Currency = "USD", Customer = "ABC", Date = DateTime.Now, Description = "TURBINE", PartNumber = "1222", Type = "sALE", UnitPrice = 565 });



                    return query.Take(5).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<PartNumberHit> GetPartNumberHits1()
        {
            const string MethodName = "GetPartNumberHits()";
            try
            {
                List<PartNumberHit> query = new List<PartNumberHit>();
                query.Add(new PartNumberHit { Hits = 35, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 25, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 20, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 12, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 5, PartNumber = "12345" });
                return query.Take(5).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<PartNumberHit> GetPartNumber30DayHits1()
        {
            const string MethodName = "GetPartNumberHits()";
            try
            {
                List<PartNumberHit> query = new List<PartNumberHit>();
                query.Add(new PartNumberHit { Hits = 35, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 25, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 20, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 12, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 5, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 35, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 25, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 20, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 12, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 5, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 35, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 25, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 20, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 12, PartNumber = "12345" });
                query.Add(new PartNumberHit { Hits = 5, PartNumber = "12345" });
                return query.Take(15).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<GoodRecevied> GetGRNFeeds1()
        {
            const string MethodName = "GetGRNFeeds()";
            try
            {
                List<GoodRecevied> query = new List<GoodRecevied>();
                query.Add(new GoodRecevied { Customer = "ABC", Date = DateTime.Now, Description = "TEST", GRN = "23423", OrderNumber = "23324", OrderType = "Sale", PartNumber = "1222", Qty = 5, SerialNumber = "232" });
                query.Add(new GoodRecevied { Customer = "ABC", Date = DateTime.Now, Description = "TEST", GRN = "23423", OrderNumber = "23324", OrderType = "Sale", PartNumber = "1222", Qty = 5, SerialNumber = "232" });
                query.Add(new GoodRecevied { Customer = "ABC", Date = DateTime.Now, Description = "TEST", GRN = "23423", OrderNumber = "23324", OrderType = "Sale", PartNumber = "1222", Qty = 5, SerialNumber = "232" });
                query.Add(new GoodRecevied { Customer = "ABC", Date = DateTime.Now, Description = "TEST", GRN = "23423", OrderNumber = "23324", OrderType = "Sale", PartNumber = "1222", Qty = 5, SerialNumber = "232" });
                query.Add(new GoodRecevied { Customer = "ABC", Date = DateTime.Now, Description = "TEST", GRN = "23423", OrderNumber = "23324", OrderType = "Sale", PartNumber = "1222", Qty = 5, SerialNumber = "232" });
                query.Add(new GoodRecevied { Customer = "ABC", Date = DateTime.Now, Description = "TEST", GRN = "23423", OrderNumber = "23324", OrderType = "Sale", PartNumber = "1222", Qty = 5, SerialNumber = "232" });


                return query.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<SalesOrder> GetInvoiceMTDTotals1()
        {
            const string MethodName = "GetInvoiceMTDTotals()";
            try
            {
                DateTime StartDate = FirstDayOfMonth(DateTime.Now);
                DateTime EndDate = LastDayOfMonth(DateTime.Now);

                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from invoiceheader in dc.INVC_HEADER
                                where (
                                (invoiceheader.INVOICE_DATE >= StartDate && invoiceheader.INVOICE_DATE <= EndDate)
                                && invoiceheader.POST_STATUS == 3
                                && (invoiceheader.INVC_TYPE == "I" || invoiceheader.INVC_TYPE == "M"))
                                select new SalesOrder
                                {
                                    SalesNumber = invoiceheader.INVC_NUMBER
                                   ,
                                    Date = invoiceheader.INVOICE_DATE
                                     ,
                                    TotalAmount = invoiceheader.FOREIGN_AMOUNT.Value
                                      ,
                                    Type = invoiceheader.INVC_TYPE
                                     ,
                                    Description = invoiceheader.POST_DESC
                                };


                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }

        public IEnumerable<SalesOrder> GetInvoiceTodayTotals1()
        {
            const string MethodName = "GetInvoiceTodayTotals()";
            try
            {
                DateTime TodayDate = DateTime.Now;


                using (QuantumEntities dc = new QuantumEntities())
                {
                    var query = from invoiceheader in dc.INVC_HEADER
                                where (
                                (
                                    invoiceheader.INVOICE_DATE.Day == TodayDate.Day
                                   && invoiceheader.INVOICE_DATE.Month == TodayDate.Month
                                   && invoiceheader.INVOICE_DATE.Year == TodayDate.Year
                                )
                                && invoiceheader.POST_STATUS == 3
                                && (invoiceheader.INVC_TYPE == "I" || invoiceheader.INVC_TYPE == "M")
                               )
                                select new SalesOrder
                                {
                                    SalesNumber = invoiceheader.INVC_NUMBER
                                   ,
                                    Date = invoiceheader.INVOICE_DATE
                                     ,
                                    TotalAmount = invoiceheader.FOREIGN_AMOUNT.Value
                                      ,
                                    Type = invoiceheader.INVC_TYPE
                                     ,
                                    Description = invoiceheader.POST_DESC
                                };


                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(CLASSID + ":" + MethodName + " " + ex.Message);
            }
        }
        #endregion
    }
}
