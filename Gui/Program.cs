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
builder.Services.AddScoped<ITripListBll, TripListBll>();
builder.Services.AddScoped<ITripListDal, TripListDal>();
builder.Services.AddScoped<ICommentBll, CommentBll>();
builder.Services.AddScoped<ICommentDal, CommentDal>();
builder.Services.AddScoped<IProductTypeDal, ProductTypeDal>();
builder.Services.AddScoped<IProductTypeBll, ProductTypeBll>();
builder.Services.AddScoped<IAttractionListProductDal, AttractionListProductDal>();
builder.Services.AddScoped<IAttractionListProductBll, AttractionListProductBll>();
builder.Services.AddScoped<IStorageTypeDal, StorageTypeDal>();
builder.Services.AddScoped<IStorageTypeBll, StorageTypeBll>();
builder.Services.AddScoped<IAttractionTypeBll, AttractionTypeBll>();
builder.Services.AddScoped<IAttractionTypeDal, AttractionTypeDal>();
builder.Services.AddScoped<IPersonStateBll, PersonStateBll>();
builder.Services.AddScoped<IPersonStateDal, PersonStateDal>();
builder.Services.AddScoped<IOpeningHourDal, OpeningHourDal>();
builder.Services.AddScoped<IOpeningHourBll, OpeningHourBll>();
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
