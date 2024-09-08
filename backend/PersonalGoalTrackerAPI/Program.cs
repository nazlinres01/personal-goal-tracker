using Microsoft.EntityFrameworkCore;
using PersonalGoalTrackerApi.Data; // Veri katmanınızın adı

var builder = WebApplication.CreateBuilder(args);

// Veritabanı bağlantı dizesini yapılandır
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Diğer servisleri ekle
builder.Services.AddControllers();
// Diğer gerekli servisler burada eklenir

var app = builder.Build();

// Hata işleme ve yönlendirme
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
