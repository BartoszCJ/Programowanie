# Programowanie
1. Schemat bazy danych na którym będzie wzorowane ćwiczenie:
![343598541_1299854454221756_3384721734443329005_n](https://user-images.githubusercontent.com/106112792/236931095-601dd869-418b-4db7-ae3b-9efd4d511602.png)

2. Pierwszym krokiem jest zainstalowanie Microsoft.EntityFrameworkCore.Tools oraz Microsoft.EntityFrameworkCore.SqlServer
3. Do podłączenia sie z SQL używamy komendy  Scaffold-DbContext "Server=.\SQLExpress;Database=Pizzeria;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
4. Tworzymy wszystkie klasy zawierające tabele z schematu.
5. Komendą Add-Migrations dodajemy migracje.
6. Tworzymy DbSety oraz dodajemy relacje takie jak na schemacie.
7. Tworzymy bazę danych poleceniem Update-Database
