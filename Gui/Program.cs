using AutoMapper;
using Bll;
using Dal;
using Entity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//הזרקת התלויות
builder.Services.AddScoped<IUserDal, UserDal>();
builder.Services.AddScoped<IUserBll, UserBll>();
builder.Services.AddScoped<IAttractionBll, AttractionBll>();
builder.Services.AddScoped<IAttractionDal, AttractionDal>();
builder.Services.AddScoped<IProductBll, ProductBll>();
builder.Services.AddScoped<IProductDal, ProductDal>();
builder.Services.AddScoped<ISavedAttractionBll, SavedAttractionBll>();
builder.Services.AddScoped<ISavedAttractionDal, SavedAttractionDal>();
builder.Services.AddScoped<IAttractionListBll, AttractionListBll>();
builder.Services.AddScoped<IAttractionListDal, AttractionListDal>();
builder.Services.AddHttpContextAccessor();
//הוספת ה database
builder.Services.AddDbContext<ElishevaMHadasBListsTripContext>();
//mapper
var config = new MapperConfiguration(m =>
  m.AddProfile(new MapperProfile()));
IMapper map = config.CreateMapper();
builder.Services.AddSingleton(map);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//input from clinet with this tool
builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000",
                                "http://www.contoso.com")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(MyAllowSpecificOrigins);

app.Run();
