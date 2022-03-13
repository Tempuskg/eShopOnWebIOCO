# eShopOnWeb reorganized to Interface Oriented Code Organization(IOCO)
By Darren J. McLeod
Based on Microsoft Full web sample [eShopOnWeb](https://github.com/dotnet-architecture/eShopOnWeb)

[eShopOnWeb](https://github.com/dotnet-architecture/eShopOnWeb) is a sample ASP.NET Core reference application, powered by Microsoft, demonstrating a single-process (monolithic) application architecture and deployment model.
I refactored the Web project of this app to demonstrate my idea of having IOCO as described in my blog post [IOCO](https://www.darrenmcleod.com/2022/03/interface-oriented-code-organizationioco.html) to organize the code based on the UI/API.
I hope developers find it useful, and start organizing their code around the UI/API to make code more modular, cohesive and easier to navigate.

I refactored most of the Web project code into the following top level folders of the Web project
1. Admin
2. Basket
3. Catalog
4. Error
5. Manage
6. Order
7. Privacy
8. User

These folders were based on the URL, for example Manage comes from https://localhost:44315/manage/my-account, or the page title in the case of Catalog which is the default page and has just the site url https://localhost:44315/
In the process I removed the Extensions, Interfaces, Pages, Services, ViewModels\Manage, Views\Manage, and Views\Order folders. 

I left the Areas folder because it is hard coded in the .NET source code and can't be customized.

I left the Account code as I didn't think it would be easy to change.
