MobileWorkshop
==============

Initiales clonen des repositories:

git clone https://github.com/tobiaszuercher/MobileWorkshop.git

## Aufgabe 1: Liste Darstellen

git checkout aufgabe-1 für die Ausgangslage.
* MainPage.xaml: Mithilfe des LongListSelector die Customers anzeigen

## Aufgabe 2: Jumplist
Jumplist einbauen. Detaillierte hilfe kann unter http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj244365(v=vs.105).aspx gefunden werden. Die Hilfsklasse ist bereits im Projekt.

### Aufgabe 3: Navigation zu Detail Page

git checkout aufgabe-3 für Ausgangslage

Navigation Nach
* SelectionChanged Event im LongListSelector registrieren und implementieren
* Mithilfe des NavigationService navigieren
* Bei CustomerDetailPage OnNavigatedTo überschreiben & DataContext setzen


### Aufgabe 4: Refresh Button auf MainPage
git checkout loesung-3 (kann auch von deiner Lösung weiter gearbeitet werden)

* Refresh Button Hinzufügen
* Im ButtonClick Handler kann via App auf den UI Service zugegriffen werden

Musterlösung: git checkout loesung-4

### Aufgabe 5: Add Customer

* Add Button in der AppBar von MainPage hinzufügen
* Via UI Service User erstellen & Navigieren
* DetailPage: Save Button hinzufügen (Icons und Resources bereits vorhanden). Achtung: Es gibt ein Binding Bug in WP8, rufe darum vor dem Save UpdateFocusedElement() auf.

### Aufgabe 6: Delete Customer
* Keine tipps, das sollte nun alleine machbar sein :)

Musterlösung für die komplette CRUD Anwendung: git checkout loesung-4 
