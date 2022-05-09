using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Entities
{
    public partial class Service
    {
        public string DiscountText
        {
            get
            {
                if (Discount == 0 || Discount == null)
                    return "";
                else
                    return $"* скидка {Discount * 100}%";

            }
        }

        public string HasDiscountVisibility
        {
            get
            {
                if (Discount == 0 || Discount == null)
                    return "Collapsed";
                else
                    return "Visible";

            }
        }

        public double CostWithDicount
        {
            get
            {
                if (Discount > 0)
                {
                    return (double)Cost * (1 - Discount.Value);
                }
                else
                {
                    return (double)Cost;
                }
            }
        }

        public string TotalCostText
        {
            get
            {
                return $"{CostWithDicount} рублей за {DurationInSeconds / 60} минут";
            }
        }
        public string BackColor
        {
            get
            {
                if (Discount > 0)
                    return "#D1FFD1";
                else
                    return "White";
            }
        }

        public string AdminControlsVisibility
        {
            get
            {
                //1 - admin, 2 - user
                if (App.CurrentUser.RoleId == 1)
                {
                    return "Visible";
                }
                else
                {
                    return "Hidden";
                }
            }
        }
    }
}
