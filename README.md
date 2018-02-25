# Klassenbuchgenerator (WIP)

## Startseite
- Textfelder
	- Name
	- Passwort
## Klassenauswahl
- Auswahlliste
	- Lehrer
	- Klassen
	- Fach
- Buttons
	- bekomme Klassenbuch

ID vom Lehrer (search personId)

# Funktionen

## login
### Parameter
- string name
- password
### Return
- string sessionId

## logout
### Parameter
- string sessionId
### Return
- void

## bekomme Klassenbucheinträge
### Parameter
- int klassenId
- int lehrerId
- string sessionid
### Rückgabe
- JSON-Array mit je Eintrag
	- Thema
	- Datum
	- Abewesende Schüler
	- [{
			"date": int, // 20170925
			"startTime": int, // 850
			"endTime": int, // 925
			"topic": string, // SQL INNER JOIN
			"absenceStudents": [{
				"name": string // Max Mustermann
			}]
		}]
### Ablauf
- Suche Klasse
- bekomme Stundenplan vom Schuljahr von der Klasse
- suche dazu fehlende Schüler

## bekomme Klassenbuch
### Parameter
- JSON-Array
### Rückgabe
- PDF mit Tag, Inhalt, fehlende Schüler
### Ablauf
- Verarbeite Array zu PDF
