using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Constants
{
    public static class Messages 
    {

 
        public static string CarAdded = "Araba eklendi";
        public static string ColorAdded = "Renk eklendi";
        public static string BrandAdded = "Marka eklendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string RentalAdded = "Araç kiralandı";

        public static string CarUpdated = "Araba güncellendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustmerUpdated = "Müşteri güncellendi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";

        public static string CarDeleted = "Araba silindi";
        public static string ColorDeleted = "Renk silindi";
        public static string BrandDeleted = "Marka silindi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string RentalDeleted = "Araç silindi";

        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
      


        public static string CarListed= "Arabalar listelendi";
        public static string ColorListed = "Renkler listelendi";
        public static string BrandListed = "Markalar listelendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string RentalListed = "Kiralık araçlar listelendi";
        public static string NonRentalListed = "Kiradaki araçlar listelendi";

        public static string MaintenanceTime="Sistem bakımda";
        public static string RentalRented;
        internal static string RentError="Araç zaten kirada olduğundan kiralanamaz";
        internal static string RentDateError="Araç bugünden daha önceki bir tarihe kiralanamaz";
        internal static string CategoryLimitExceeded="En fazla 5 resim eklenebilir.";
        internal static string ImageAdded="Resim Eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
