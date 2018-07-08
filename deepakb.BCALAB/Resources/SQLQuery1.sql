create table watches (gender varchar(5),company varchar(50),model varchar(50), number integer,pic varchar(250),qty integer, price integer, warranty integer)
insert into watches values('Men','Bell_Ross','BRV2-94 Black Steel',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Bell_Ross\BRV2-94 Black Steel.jpg',15,199394,1)
insert into watches values('Men','Bell_Ross','BR-X1 BLACK TITANIUM',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Bell_Ross\BR-X1 BLACK TITANIUM.jpg',7,1053698,5)
insert into watches values('Men','Bremont','MODEL 247 STAINLESS STEEL',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Bremont\MODEL 247 STAINLESS STEEL.jpg',10,446094,3)
insert into watches values('Men','Bremont','S301',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Bremont\S301.jpg',12,297250,2)
insert into watches values('Men','Panerai','LUMINOR 1950 CARBOTECH',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Panerai\LUMINOR 1950 CARBOTECH.jpg',5,1177000,7)
insert into watches values('Men','Panerai','LUMINOR 1950 SEALAND',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Panerai\LUMINOR 1950 SEALAND.jpg',10,408340,3)
insert into watches values('Men','Ulysse_Nardin','Executive Dual Time',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Ulysse_Nardin\Executive Dual Time.jpg',3,1624676,10)
insert into watches values('Men','Ulysse_Nardin','Marine Chronograph',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Ulysse_Nardin\Marine Chronograph.jpg',8,856800,8)
insert into watches values('Women','Breitling','COLT LADY',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Breitling\COLT LADY.jpg',15,206480,1)
insert into watches values('Women','Breitling','GALACTIC 36 AUTOMATIC',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Breitling\GALACTIC 36 AUTOMATIC.jpg',13,293430,1)
insert into watches values('Women','Gucci','Light Horsebit',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Gucci\Light Horsebit.jpg',17,116450,1)
insert into watches values('Women','Gucci','Vintage Web',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Gucci\Vintage Web.jpg',25,50602,1)
insert into watches values('Women','Piaget','ALTIPLANO ROSE',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Piaget\ALTIPLANO ROSE.jpg',4,1571596,10)
insert into watches values('Women','Piaget','LIMELIGHT GALA',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Piaget\LIMELIGHT GALA.jpg',3,1945925,11)
insert into watches values('Women','Rolex','DAY-DATE 36',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Rolex\DAY-DATE 36.jpg',4,1686750,10)
insert into watches values('Women','Rolex','PEARLMASTER 39',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Rolex\PEARLMASTER 39.jpg',1,3921693,20)
insert into watches values('Women','TAG_Heuer','CARRERA',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\TAG_Heuer\CARRERA.jpg',20,116800,1)
insert into watches values('Women','TAG_Heuer','LINK',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\TAG_Heuer\LINK.jpg',15,222650,1)
insert into watches values('Women','tiffany_co','Cocktail',1,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\tiffany_co\Cocktail.jpg',4,1427250,9)
insert into watches values('Women','tiffany_co','East West',2,'C:\Users\deepakb.BCALAB\Desktop\Resources\Women\tiffany_co\East West.jpg',15,227062,1)
select * from watches

create table com (com varchar(50), pic varchar(250), type varchar(5))
insert into com values('Breitling','C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Breitling.JPG','Women')
insert into com values('Gucci','C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Gucci.JPG','Women')
insert into com values('Piaget','C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Piaget.JPG','Women')
insert into com values('Rolex','C:\Users\deepakb.BCALAB\Desktop\Resources\Women\Rolex.JPG','Women')
insert into com values('TAG_Heuer','C:\Users\deepakb.BCALAB\Desktop\Resources\Women\TAG_Heuer.JPG','Women')
insert into com values('tiffany_co','C:\Users\deepakb.BCALAB\Desktop\Resources\Women\tiffany_co.JPG','Women')
insert into com values('Bell_Ross','C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Bell_Ross.JPG','Men')
insert into com values('Blancpain','C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Blancpain.JPG','Men')
insert into com values('Bremont','C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Bremont.JPG','Men')
insert into com values('iwc_schaffhausen','C:\Users\deepakb.BCALAB\Desktop\Resources\Men\iwc_schaffhausen.JPG','Men')
insert into com values('Panerai','C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Panerai.JPG','Men')
insert into com values('Ulysse_Nardin','C:\Users\deepakb.BCALAB\Desktop\Resources\Men\Ulysse_Nardin.JPG','Men')
select * from com

create table cust (bill_no varchar(20), name varchar(20), ph_no decimal(10), qty int, tot int, purchase_date date, warranty_till date)
select * from cust