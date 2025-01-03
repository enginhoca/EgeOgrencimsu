using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EgeApp.Frontend.Mvc.Data;
using EgeApp.Frontend.Mvc.Data.Entities;
using EgeApp.Frontend.Mvc.Helpers.Abstract;
using EgeApp.Frontend.Mvc.Models.Email;
using EgeApp.Frontend.Mvc.Helpers.Concrete;
using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Mail;
using System.Net;


var builder = WebApplication.CreateBuilder(args);

// Controllers ve Views için yapılandırma
builder.Services.AddControllersWithViews();

// DbContext ve Identity yapılandırması
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// ToastNotification yapılandırması
builder.Services.AddNotyf(config =>
{
    config.Position = NotyfPosition.TopRight;
    config.DurationInSeconds = 5;
    config.IsDismissable = true;
});

// Session yapılandırması
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(5);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// E-posta gönderimi için bağımlılık ekleme
builder.Services.AddScoped<IEmailSenderHelper, EmailSenderSmtp>();

// Razor Pages desteği (isteğe bağlı)
builder.Services.AddRazorPages();

builder.Services.AddHttpClient<IApiClient, ApiClient>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5200/"); // API adresi
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
});


var app = builder.Build();

// Hata yönetimi
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.UseNotyf();

// Admin Area Rota
app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

// Varsayılan Rota
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Razor Pages (isteğe bağlı)
app.MapRazorPages();

app.Run();

// EmailSenderSmtp Sınıfı
public class EmailSenderSmtp : IEmailSenderHelper
{
    private readonly string _host;
    private readonly int _port;
    private readonly bool _enableSsl;
    private readonly string _userName;
    private readonly string _password;

    public EmailSenderSmtp(IConfiguration configuration)
    {
        _host = configuration["EmailSender:Host"];
        _port = configuration.GetValue<int>("EmailSender:Port");
        _enableSsl = configuration.GetValue<bool>("EmailSender:EnableSSL");
        _userName = configuration["EmailSender:UserName"];
        _password = configuration["EmailSender:Password"];
    }

    public async Task SendEmailAsync(SendEmailModel model)
    {
        await SendEmailAsync(model.EmailTo, model.Subject, model.Body);
    }

    public async Task SendEmailAsync(string emailTo, string subject, string body)
    {
        var client = new SmtpClient(_host, _port)
        {
            Credentials = new NetworkCredential(_userName, _password),
            EnableSsl = _enableSsl
        };

        var mailMessage = new MailMessage(_userName, emailTo, subject, body)
        {
            IsBodyHtml = true
        };

        await client.SendMailAsync(mailMessage);
    }
}