using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Ürün Eklendi!";
		public static string ProductNameInvalid = "Ürün ismi geçersizke";
		public static string MaintenanceTime = "Sistem bakımda";
		public static string ProductsListed = "Ürünler listelendi";
		public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün olabilir";
		public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
		public static string CategoryLimitExceded = "Kategori sayısı çok fazla!";
		public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
		public static string UserNotFound = "Kullanıcı bulunamadı";
		public static string UserAlreadyExists = "Kullanıcı mevcut";
		public static string SuccessfulLogin = "Giriş başarılı";
		public static string UserRegistered = "Kullanıcı oluşturuldu";
		public static string PasswordError = "Şifre hatalı";
		public static string AccessTokenCreated = "Erişim belirtici oluşturuldu";
	}
}
