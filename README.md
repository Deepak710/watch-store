# watch-store

## This is a simple Windows Application to replicate a Watch E-Commerce Application(x86), to be used by the store employees

### To Run this file,
1. Make Sure you have [Visual Studio](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?ch=pre&sku=Professional&rel=15), [SQL Server 2017](https://go.microsoft.com/fwlink/?linkid=853016) and [SQL Server Management Studio](https://go.microsoft.com/fwlink/?linkid=875802) installed
1. [Clone](https://github.com/Deepak710/watch-store.git)/[Download](https://github.com/Deepak710/watch-store/archive/master.zip) this repo and paste in the Visual Studio Projects folder in the Documents folder
1. Paste the Resources folder on your desktop
1. Run SQLQuery1.sql using SSMS
1. Open Watch.sln using Visual Studio, and replace in all forms 
    ```vbnet
      C:\Users\deepakb.BCALAB\Desktop\
    ```
    to
    ```vbnet
      ' your desktop path '
    ```
    
    and in
    
    ```vbnet
      New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
    ```
    change Data Source to your SSMS Database name
1. Debug the code in Visual Studio

### Features:
1. There are only six watch manufacturers in Men and Women categories, but Admins can add 'n' number of watches under each manufacurer by providing watch picture and other necessary details
1. Choose the make of watch the cutomer requires and the number of watches. Provide Name and number of the customer. A bill will be generated with Warranty details (Bill number is gender+manufacturer+watchnumber+year+dayofyear+hour+minute+second). Not in printable form sadly...
1. To check for warranty, go to the admin tab by providing username ("Deepak Balaji") and password ("DMB") in the respective watch. This will show the purchase history of that particular watch
1. Admin can also change the rate and quantity (stock) of the watches

Contact Me: [Telegram](https://web.telegram.org/#/im?p=@AzorAhoy)
