### Utworzenie bazy danych
Bazę danych tworzycie na podstawie skryptu zawartego w repozytorium bazanapraw.sql. 
	1. Wchodzicie do Microsft SQL Management Studio
	2. Łączycie się do lokalnego serwera, u mnie jest to <p>(localdb)\MSSQLLocalDb</p>. U was nazwa serwera może się różnić. Wszystko zależy od tego co podaliście podczas instalacji.
	3. Prawym przyciskiem myszy na otworzony serwer w okienku Object Explorer, new Query, kopiujecie zawartość bazanapraw.sql, wklejacie i klikacie Execute. Powinna zostać wygenerowana baza danych. Nie wykluczam, że najzwyklejsze odpalenie skryptu sql od razu utworzy bazę w odpowiednim serwerze, ale nie wiem, nie testowałem.


### Połączenie solucji z bazą danych
Gdy już mamy utworzoną bazę to czas odpalić solucję. Aby aplikacja mogła komunikować się z bazą danych, to powinniśmy w pliku App.config Startup Project(projektu, który jest uruchamiany przy starcie aplikacji) dodać tzw. ConnectionString. Jest to specjalny ciąg znaków z którego ADO .NET / EntityFramework zaciąga parametry do połączenia z bazą danych. Aktualnie w projekcie View(to jest nasz Startup Project) w pliku App.config znajduje się ConnectionString, który został wygenerowany podczas dodawania modelu to projektu, jednak jest to ConnectionString, który został wygenerowany z mojej bazy danych. Dla waszych baz danych może się on różnić(wady pracy na lokalnej bazie danych). Możecie po prostu uruchomić projekt i spróbować dodać klienta do bazy poprzez naciśnięcie guzika. Jeśli dostaniecie exception z informacjami o nieprawidłowym ConnectionStringu, to prawdopodobnie trzeba go zamienić. W tym celu:
	1. W Visual Studio z zakładki Views wybieracie SQL Server Object Explorer.
	2. W nowootwartej zakładce rozwijacie kolejno: SQL Server, (localdb)\MSSQLLocalDb (Chodzi o wasz lokalny serwer SQL. Dla was nazwa może być inna), Databases
	3. Powinny wam się załadować wasze lokalne bazy danych. 
	4. Klikacie prawym na bazę BazaNapraw i wybieracie Properties
	5. Znajdujecie pole Connection string, kopiujecie jego zawartość do frazy <p>integrated security=True;</p> włącznie. Czyli powinniśmy dostać coś w stylu: <p>Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BazaNapraw;Integrated Security=True;</p>
	6. Zastępujecie skopiowaną zawartością w pliku App.config w projekcie View w ConnectionString RepairContext tekst od słów <p>Data Source</p> do słów <p>Integrated Security=True;</p>. Dzięki temu otrzymujecie swój własciwy ConnectionString, który powinien wyglądać:
	<p> <add name="RepairContext" connectionString="metadata=res://*/RepairContext.csdl|res://*/RepairContext.ssdl|res://*/RepairContext.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BazaNapraw;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" /> </p>

	Warto też sprawdzić czy nie wystarczy w istniejącym już ConnectionStringu zamienić po prostu nazwy serwera, jednak nie mam jak tego sprawdzić, bo nie mam innego serwera lokalnego.

I to zasadniczo wszystko. Wiem, że ta zamiana ConnectionString to jest pojebana, ale kurde takie są "zalety" pracy na lokalnej bazie danych.

Elo!
	
