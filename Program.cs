using KitchenEquip.Services;

var builder = WebApplication.CreateBuilder(args);

// ─── Services ───────────────────────────────────────────────
builder.Services.AddControllersWithViews();

// Registrar o serviço de produtos como Singleton (mock).
// Para produção: trocar por AddScoped<IProductService, DbProductService>()
// com EF Core e repositório adequado.
builder.Services.AddSingleton<IProductService, MockProductService>();

// ─── App pipeline ───────────────────────────────────────────
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Rotas convencionais
app.MapControllerRoute(
    name: "product-detail",
    pattern: "produto/{id:int}",
    defaults: new { controller = "Products", action = "Details" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
