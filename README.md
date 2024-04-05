# Lern-Periode 4

23.2 bis 5.4.2024

## Grob-Planung

1. Ich habe momentan genügente noten
2. Direkt einen sauberen Code zu schreiben
3. Eine digitale Enigma
4. Paralleles Progrmieren 

## 20.2.2024


Heute habe ich mich intensiv mit der Grobplanung für den Bau einer Enigma-Maschine auseinandergesetzt. Nach ausgiebiger Überlegung und zahlreichen Ideenskizzen auf einem Whiteboard habe ich mich dazu entschieden, für die Veränderung der Buchstaben ein Integer-Array zu verwenden, dessen Werte im Bereich von -25 bis 25 liegen können. Diese Entscheidung bietet eine flexible Möglichkeit, die Buchstaben zu transformieren und ermöglicht eine vielseitige Konfiguration für die Enigma.

Während meiner Recherche im Internet bin ich auf den Aufbau der Enigma I gestoßen, und ich fand die Informationen auf der Wikipedia-Seite (https://de.wikipedia.org/wiki/Enigma_I) besonders hilfreich. Der Artikel bietet detaillierte Einblicke in die Struktur und Funktionsweise der Enigma I, 
## 27.2.2024

- [x] Alle Walzen der Enigma I in C# nachbilden.
- [x] Klasse erstellen, die kontrolliert einen Array von Großbuchstaben in einen Array von Ganzzahlen umwandelt.
- [?] Rotation der Walzen erstellen.
- [?] Zwei Walzen integrieren.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               |   stimmt die verwandlung?   https://de.wikipedia.org/wiki/Enigma_I|     ABC           | EKM         |    true   |
| 2              |     Class      Enigma           |   Class created             |      use every walze          |     ?    |
| 3            |        Class Enigma              |           ABC     |       ELO         |    ?     |
| 4               |        Class Enigma              |       ?         |       ?         |     ?    |

✍️Heute habe ich einige meiner Ziele erreicht, da ich nach langen Besprechungen mit meinem Vater auf eine elegante Lösung gekommen bin, um mehrere Rollen als Ableitung zu machen.

Leider ist es sehr zeitaufwändig und kann daher nicht in einem Tag gemacht werden, da ich mich zuerst in abgeleitete Klassen einlesen muss.
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 8.3.2024

- [x] Einen Tieferen Punkt für den Anfang der Abgeleiteten klasse für mehr moglichkeiten
- [x] umschreiben der Klasse um coustem länge der walze
- [x] Historisch umk erstellen
- [ ] erster output mit enigma und usk
Heute konnte ich einige meiner gesteckten Ziele erfolgreich umsetzen, wenngleich nicht alle. Der Grund dafür lag darin, dass die erste Aufgabe mehr Zeit in Anspruch nahm als ursprünglich angenommen. Trotz dieser Herausforderung bin ich mit den erzielten Fortschritten zufrieden. Die Schwierigkeiten haben mir die Gelegenheit geboten, tiefer in die Thematik einzusteigen und meine Fähigkeiten weiter zu vertiefen. Die Umstrukturierung der Enigma-Klasse, um einen tieferen Einstiegspunkt für abgeleitete Klassen zu schaffen und die Anpassung der Klasse für benutzerdefinierte Walzenlängen, sind bedeutende Schritte. Die Implementierung einer historischen Umkehrwalze steht noch aus, aber insgesamt betrachte ich den Tag als erfolgreich.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               | umschreiben der Klasse um coustem länge der walze  |        age        |     aeg     |   true    |
| 2               |  erstelung von historisch ukw |    ?            |      istorisch ukw    |   true    |

 ## 22.3.2024
- [x] Ich lese mich in Override Methods()
- [x] Ersetze den Code von Vertauscher.vertausche()
- [ ] Baue ein System ein damit die Enigma Mehrer rollen speichern kann
- [ ] Buxfixes um ein erstes Resultat zu bekommen

✍️Heute bin ich leider kaum vorangekommen, da ich viele Probleme mit dem Implementieren von Overrides hatte. Leider bin ich heute oft auf Hindernisse gestoßen, die ich noch nicht lösen konnte, da ich meine Fähigkeiten überschätzt und meine Ziele sehr ambitioniert gesetzt habe. Da ich kaum Fortschritte gemacht habe, werde ich über das Wochenende noch einmal in Ruhe daran arbeiten und dann eine akzeptable Version hochladen."

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1.1              | Die overidewalze funktioniert Methods für die Walzen kreiret habe   |        a        |     Irgendwass     |   false    |
| 1.2               | Die Bearbeitete Version  des overidewalze funktioniert Methods für die Walzen  |        a        |     Irgendwass     |   false    |
| 1.3               | Die Bearbeitete Version  des overidewalze funktioniert Methods für die Walzen  |        a        |     Irgendwass     |   False    |
| 1.3               | Die Bearbeitete Version  des overidewalze funktioniert Methods für die Walzen  |        a        |     e     |   True    |

05.4.2024
- [x] Einiga Erlauben mit spezifischen inputs einen output zu geben
- [ ] Einiga Erlauben mit Allgemeinen inputs einen output zu geben(IList?)
- [x] Codecleanup

✍️Heute habe ich es gerade so geschafft, dass das Programm funktioniert. Hauptsächlich habe ich Fehler behoben, zum Beispiel hatte die UKW_A einen fehlenden Buchstaben, der eine symmetrische Verschlüsselung verhinderte. Außerdem habe ich einige Optimierungen vorgenommen, die zwar im Ablauf des Programms keinen signifikanten Einfluss hatten, da ich den Code verbessern wollte oder es aus Zeitgründen nicht erforderlich war.

## Reflexion
✍️Im Nachhinein habe ich die Ziele des letzten Lern-Ateliers NICHT erreicht. Der Code wurde schnell unleserlich, während der Versuch, mit Ableitungen zu arbeiten, das Problem verschlimmert hat. Obwohl ich nicht fertig geworden bin, war das Projekt doch noch wertvoll, da ich meine Fähigkeiten und mein Wissen in C# verbessert habe. Leider muss ich auch zugeben, dass ich viel Code geschrieben habe, den ich nicht benutzt habe.

Deshalb ist mein Ziel (wie bei der letzten Lernperiode) für die nächste Lernperiode, direkt von Anfang an einen sauberen Code zu schreiben und für Testfälle anspruchsvollere Anforderungen zu stellen. Ein weiteres, das ich ausprobieren will, ist, dass ich vor dem Start des Projektes einen Plan erstelle, der das Projekt in seine Einzelteile aufteilt, um einen besseren Überblick zu bekommen.

Momentaner code in branches 05.04
