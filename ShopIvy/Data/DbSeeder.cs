using ShopIvy.Constants;
using Microsoft.AspNetCore.Identity;
using ShopIvy.Models;

namespace ShopIvy.Data;
public class DbSeeder
{
    public static async Task SeedDefaultData(IServiceProvider service){
        var userManager = service.GetService<UserManager<Users>>();
        var roleManager = service.GetService<RoleManager<IdentityRole>>();

        //Add role to db
        await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));

        //create admin account
        var admin=new Users{
            UserName="admincodengu@gmail.com",
            Email="admincodengu@gmail.com",
            Ho="Trần",
            Ten="Xuân Hoàng",
            GioiTinh="Nam",
            Tinh_ThanhPho="Thanh Hóa",
            Quan_Huyen="Nga Sơn",
            Phuong_Xa="Nga Thạch",
            DiaChi="Thôn 1 Phương Phú",
            NgaySinh=DateTime.Parse("2001-08-22")
    
        };
        var isExistAdmin=await userManager.FindByEmailAsync(admin.Email);
        if(isExistAdmin is null){
            await userManager.CreateAsync(admin,"Txhoang11!");
            await userManager.AddToRoleAsync(admin,Roles.Admin.ToString());
        }
        
    }
}