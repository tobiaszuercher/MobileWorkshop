MobileWorkshop
==============

Initiales clonen des repositories:

git clone https://github.com/tobiaszuercher/MobileWorkshop.git

### Aufgabe 1: Liste Darstellen

git checkout aufgabe-1 für die Ausgangslage.
* MainPage.xaml: Mithilfe des LongListSelector die Customers anzeigen

### Aufgabe 2: Jumplist
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

# Weitere Aufgaben

Nun hast du eine funktionierende Applikation um deine Kunden zu Verwalten. Es steht dir frei einige Bereiche aus der Windows Phone 8 Welt selber auszuprobieren. Hier einige Ideen:

### Live Tiles implementieren (Random Customer anzeigen)
http://developer.nokia.com/community/wiki/Live_Tile_Templates_in_Windows_Phone_8
http://msdn.microsoft.com/en-us/library/windowsphone/develop/hh202948(v=vs.105).aspx

### App-To-App Communication
*z.B. vCard file extension mit App Registrieren
*vCard anderer App senden oder empfangen

http://de.wikipedia.org/wiki/VCard
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206987(v=vs.105).aspx

### NFC
Kontakt sharen beim Berühren zweier Devices.
http://www.silverlightshow.net/items/Windows-Phone-8-NFC-Near-Field-Communication.aspx
http://blogs.msdn.com/b/windowsappdev/archive/2013/04/18/develop-a-cutting-edge-app-with-nfc.aspx
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207060(v=vs.105).aspx

### Maps & Location
* Kunden auf Karte anzeigen
* Kunde in der Nähe anzeigen
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207045(v=vs.105).aspx

### Speech & Voice
*Voice Command "Call" auf Kontakt
*Text-To-Speech: Das Telefon sagt die Kontaktdetails
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206958(v=vs.105).aspx
http://channel9.msdn.com/Series/Building-Apps-for-Windows-Phone-8-Jump-Start/Building-Apps-for-Windows-Phone-8-Jump-Start-13-Speech-Input-in-Windows-Phone-8

var synth = new SpeechSynthesizer();
await synth.SpeakTextAsync("....");



