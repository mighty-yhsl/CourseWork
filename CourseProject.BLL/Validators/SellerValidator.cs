﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.BLL.Repositories;
using CourseProject.DAL.Models.EF;
using Microsoft.IdentityModel.Tokens;

namespace CourseProject.BLL.Validators
{
    public class SellerValidator
    {
        public void Validate(Seller seller)
        {
            if (seller is null || seller.SellerName.IsNullOrEmpty() || seller.SellerSurname.IsNullOrEmpty() ||
                seller.Phone.IsNullOrEmpty() || seller.Email.IsNullOrEmpty())
            {
                throw new ArgumentException("Seller is null or fields of Seller is null");
            }
            if (seller.SellerSurname.Length > 40)
            {
                throw new ArgumentException("SellerSurname was greater then max length value");
            }
            if (seller.SellerName.Length > 40)
            {
                throw new ArgumentException("SellerName was greater then max length value");
            }
            if (seller.Phone.Length > 40)
            {
                throw new ArgumentException("Phone was greater then max length value");
            }
            if (seller.Email.Length > 40)
            {
                throw new ArgumentException("Email was greater then max length value");
            }
        }
    }
}