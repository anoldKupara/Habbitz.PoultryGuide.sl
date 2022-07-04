using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.BirdCategory;
using Habbitz.PoultryGuide.Application.DTOs.Budgets;
using Habbitz.PoultryGuide.Application.DTOs.Currencies;
using Habbitz.PoultryGuide.Application.DTOs.Expenses;
using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using Habbitz.PoultryGuide.Application.DTOs.Inventories;
using Habbitz.PoultryGuide.Application.DTOs.PaymentMethods;
using Habbitz.PoultryGuide.Application.DTOs.Sales;
using Habbitz.PoultryGuide.Application.DTOs.Vaccines;
using Habbitz.PoultryGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region BirdCategory
            CreateMap<BirdCategory, BirdCategoryDto>().ReverseMap();
            CreateMap<BirdCategory, BirdCategoryDetailDto>().ReverseMap();
            CreateMap<BirdCategory, BirdCategoryListDto>().ReverseMap();
            CreateMap<BirdCategory, CreateBirdCategoryDto>().ReverseMap();
            CreateMap<BirdCategory, UpdateBirdCategoryDto>().ReverseMap();
            #endregion

            #region Budget
            CreateMap<Budget, BudgetDto>().ReverseMap();
            CreateMap<Budget, BudgetDetailDto>().ReverseMap();
            CreateMap<Budget, BudgetListDto>().ReverseMap();
            CreateMap<Budget, CreateBudgetDto>().ReverseMap();
            CreateMap<Budget, UpdateBudgetDto>().ReverseMap();
            #endregion

            #region Currency
            CreateMap<Currency, CurrencyDto>().ReverseMap();
            CreateMap<Currency, CurrencyDetailDto>().ReverseMap();
            CreateMap<Currency, CurrencyListDto>().ReverseMap();
            CreateMap<Currency, CreateCurrencyDto>().ReverseMap();
            CreateMap<Currency, UpdateCurrencyDto>().ReverseMap();
            #endregion

            #region Expense
            CreateMap<Expense, ExpenseDto>().ReverseMap();
            CreateMap<Expense, ExpenseDetailDto>().ReverseMap();
            CreateMap<Expense, ExpenseLIstDto>().ReverseMap();
            CreateMap<Expense, CreateExpenseDto>().ReverseMap();
            CreateMap<Expense, UpdateExpenseDto>().ReverseMap();
            #endregion

            #region Feed
            CreateMap<Feed, FeedDto>().ReverseMap();
            CreateMap<Feed, FeedDetailDto>().ReverseMap();
            CreateMap<Feed, FeedsListDto>().ReverseMap();
            CreateMap<Feed, CreateFeedDto>().ReverseMap();
            CreateMap<Feed, UpdateFeedDto>().ReverseMap();
            #endregion

            #region Inventory
            CreateMap<Inventory, InventoryDto>().ReverseMap();
            CreateMap<Inventory, InventoryDetailDto>().ReverseMap();
            CreateMap<Inventory, InventoryListDto>().ReverseMap();
            CreateMap<Inventory, CreateInventoryDto>().ReverseMap();
            CreateMap<Inventory, UpdateInventoryDto>().ReverseMap();
            #endregion

            #region PaymentMethod
            CreateMap<PaymentMethod, PaymentMethodDto>().ReverseMap();
            CreateMap<PaymentMethod, PaymentMethodDetailDto>().ReverseMap();
            CreateMap<PaymentMethod, PaymentMethodListDto>().ReverseMap();
            CreateMap<PaymentMethod, CreatePaymentMethodDto>().ReverseMap();
            CreateMap<PaymentMethod, UpdatePaymentMethodDto>().ReverseMap();
            #endregion

            #region Sale
            CreateMap<Sale, SaleDto>().ReverseMap();
            CreateMap<Sale, SaleDetailDto>().ReverseMap();
            CreateMap<Sale, SaleListDto>().ReverseMap();
            CreateMap<Sale, CreateSaleDto>().ReverseMap();
            CreateMap<Sale, UpdateSaleDto>().ReverseMap();
            #endregion

            #region Vaccine
            CreateMap<Vaccine, VaccineDto>().ReverseMap();
            CreateMap<Vaccine, VaccineDetailDto>().ReverseMap();
            CreateMap<Vaccine, VaccineListDto>().ReverseMap();
            CreateMap<Vaccine, CreateVaccineDto>().ReverseMap();
            CreateMap<Vaccine, UpdateVaccineDto>().ReverseMap();
            #endregion  
        }
    }
}
