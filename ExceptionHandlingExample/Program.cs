
// Sistemde bir çok kullanıcı bulunmaktadır. Kullanıcı giriş yapmak istiyor.
// Kullanıcı giriş yaparken bazı Validasyon kurallarından geçmesi gerekiyor.
// Email alanı @gmail.com ile bitmelidir.
//Parola minimum 6 haneli olmalıdır.
// Sistemde ilgili kullanıcı yoksa istisna durumunu yönetiniz.
using ExceptionHandlingExample;

UserController userController = new UserController();
userController.Run();
