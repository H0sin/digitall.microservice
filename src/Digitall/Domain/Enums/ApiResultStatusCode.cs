using System.ComponentModel.DataAnnotations;

namespace Domain.Enums;

public enum ApiResultStatusCode
{
    [Display(Name = "عملیات با موفقیت انجام شد")]
    Success = 0,

    [Display(Name = "خطایی در سرور رخ داده است")]
    ServerError = 1,

    [Display(Name = "پارامتر های ارسالی معتبر نیستند")]
    BadRequest = 2,

    [Display(Name = "یافت نشد")] NotFound = 3,

    [Display(Name = "لیست خالی است")] ListEmpty = 4,

    [Display(Name = "خطایی در پردازش رخ داد")]
    LogicError = 5,

    [Display(Name = "خطای احراز هویت")] UnAuthorized = 6,

    [Display(Name = "نام کاربری یا کلمه عبور وارد شده صحیح نمی باشد")]
    InValidUserPass = 7,

    [Display(Name = "اطلاعات وارد شده تکراری می باشد")]
    Duplicate = 8,

    [Display(Name = "غیر قابل ویرایش است")]
    UnEditable = 9,

    [Display(Name = ".به دلیل وابستگی داده حذف نشد")]
    CouldNotDelete = -1,

    [Display(Name = "بلاک شده است")] Blocked = -2,

    [Display(Name = "در حال توسعه")] NotImplemented = -3,

    [Display(Name = "خطا از سمت مرزبان")] MarzbanError = -4
}