
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//build ra cac tham so dong lenh, doc tham so tu appsetting
var builder = WebApplication.CreateBuilder(args);


// muon code brazor trong C# thi bat 2 thang nay len
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//dk cac dich vu
var app = builder.Build();
//kiem tra xem co phai cdang chay loca hay khong
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else//moi truong deloy
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
//locaolhost5000->5001
//app.UseHttpsRedirection();//cmt dong nay lai co the chay bang port 5000
app.UseStaticFiles();
//bat dinh tuyen trong app
app.UseRouting();

//SinnalR
app.MapBlazorHub();
//neu khong khpo voi page nao thi chuyen vehost de xu ly
app.MapFallbackToPage("/_Host");

app.Run();

