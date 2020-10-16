using System;
using System.Collections.Generic;
using System.Linq;
using AerosparesWebAPI.Entities;
using AerosparesWebAPI.Models;

namespace AerosparesWebAPI.Repositories
{
    public interface IQuantumRepository
    {
        #region Shipping
        public IEnumerable<Shipping> GetShippingFeeds();

        public IEnumerable<Shipping> GetWarehouseShipmentsAndRepairsOrders();
        #endregion

        #region Employee Part Number, Related Totals
        public IEnumerable<PartNumberHit> GetPartNumberHits();

        public IEnumerable<GoodRecevied> GetGRNFeeds();

        public IEnumerable<PartNumberHit> GetPartNumber30DayHits();

        public IEnumerable<EmployeeSales> GetTotalEmployeeSales();

        public IEnumerable<EmployeeQuotes> GetTotalEmployeeQuotes();

        public IEnumerable<EmployeeSales> GetEmployeeMTDSalesOrders();

        public IEnumerable<EmployeeQuotes> GetEmployeeMTDQuotes();

        #endregion

        #region Invoice Totals
        public decimal GetInvoiceTodayTotals();
        public decimal GetInvoiceMTDTotals();
        public decimal GetYTDInvoiceTotals();
        public decimal GetQTDInvoiceTotals();
        public decimal GetLTMInvoiceTotals();
        #endregion

        #region Sales and Quotes Totals

        IEnumerable<SalesOrder> GetSalesOrders();
        public IEnumerable<Quote> GetQuoteFeeds();

        public int GetSalesCount(DateTime StartDate, DateTime EndDate);
        public decimal GetYTDSalesTotals();


        public decimal GetQTDSalesTotals();


        public decimal GetLTMSalesTotals();



        public decimal GetYTDQuotesTotals(DateTime StartDate, DateTime EndDate);
       

        public int GetQuotesCount(DateTime StartDate, DateTime EndDate);

        public SaleOrderToQuoteRatio GetSaleOrderToQuoteRatios();

        #endregion

        #region Purchase Order Totals

        public decimal GetPurchaseOrderTodayTotals();


        public decimal GetPurchaseOrderMTDTotals();


        public decimal GetPurchaseOrderYTDTotals();


        public decimal GetPurchaseOrderQTDTotals();

        public decimal GetPurchaseOrderLTMTotals();

        #endregion

        #region Repair Order Totals

        public IEnumerable<RepairOrder> GetRepairOrders();
        public decimal GetRepairOrderTodayTotals();

        public decimal GetRepairOrderMTDTotals();

        public decimal GetRepairOrderYTDTotals();

        public decimal GetRepairOrderQTDTotals();

        public decimal GetRepairOrderLTMTotals();

        #endregion

        #region Purchase Order Totals
        public PurchaseOrderTotals GetPurchaseOrderTotals();
        #endregion

        #region Repair Order Totals
        public RepairOrderTotals GetRepairOrderTotals();
        #endregion

        #region Slaes/Customer Type related
        public IEnumerable<SalesByCustomerType> GetSalesByCustomerType(DateTime StartDate, DateTime EndDate);

        public IEnumerable<SalesByCustomerTypeStats> GetSalesByCustomerTypeStats(DateTime StartDate, DateTime EndDate);

        public IEnumerable<SalesByAirCraftType> GetSalesByAirCraftType(DateTime StartDate, DateTime EndDate);


        public IEnumerable<SalesByAirCraftTypeStats> GetSalesByAirCraftTypeLast3months();

        public IEnumerable<SalesByAirCraftTypeStats> GetSalesByAirCraftTypeLast12months();

        #endregion

    }
}
