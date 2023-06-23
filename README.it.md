# Memory MAUI

![GitHub all releases](https://img.shields.io/github/downloads/GiorgioCitterio/MemoryMAUI/total)
![GitHub](https://img.shields.io/github/license/GiorgioCitterio/MemoryMAUI)
![GitHub deployments](https://img.shields.io/github/deployments/GiorgioCitterio/MemoryMAUI/github-pages)
![GitHub repo size](https://img.shields.io/github/repo-size/GiorgioCitterio/MemoryMAUI)
![GitHub Repo stars](https://img.shields.io/github/stars/GiorgioCitterio/MemoryMAUI)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![SQLite](https://img.shields.io/badge/sqlite-%2307405e.svg?style=for-the-badge&logo=sqlite&logoColor=white)
![Android](https://img.shields.io/badge/Android-3DDC84?style=for-the-badge&logo=android&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)

<a href="https://github.com/GiorgioCitterio/MemoryMAUI/blob/master/README.md">README.us 🇺🇸</a>

---

## Indice
- <a href="#appoverview">Panoramica dell'app</a>
- <a href="#gameplay">Modalità di gioco</a>
- <a href="#features">Funzionalità</a>
  - <a href="#difflvl">Livelli di difficoltà</a>
  - <a href="#resstor">Memorizzazione dei risultati</a>
  - <a href="#backmus">Musica di sottofondo</a>
  - <a href="#theme">Selezione del tema</a>
  - <a href="#timer">Visualizzazione punteggio e timer</a>
- <a href="#platforms">Piattaforme supportate</a>
- <a href="#sysreq">Requisiti di sistema</a>
- <a href="#installation">Installazione</a>
- <a href="#mauiversion">Versione .NET MAUI</a>
- <a href="#nuget">Pacchetti NuGet</a>
- <a href="#todo">Cambiamenti/Funzionalità da aggiungere</a>

## Panoramica dell'app <a name="appoverview"></a>
Memory MAUI è un gioco disponibile per le piattaforme Android e Windows. Offre tre livelli di difficoltà: facile, medio e difficile. Oltre ai livelli di difficoltà, il gioco supporta anche la memorizzazione dei risultati e la riproduzione di musica di sottofondo. Inoltre, sono disponibili quattro diversi temi per personalizzare l'aspetto del gioco.

## Modalità di gioco <a name="gameplay"></a>
1. Avvia l'app Memory Game sul tuo dispositivo.
2. Seleziona il tema desiderato: Arte, Marvel, Frutta, Città.
3. Seleziona il livello di difficoltà desiderato: Facile, Medio o Difficile.
4. Verrà visualizzata la griglia di gioco, composta da carte coperte.
5. Tocca una carta per girarla e rivelare l'immagine.
6. Tocca una seconda carta per girarla anche essa.
7. Se le due carte girate corrispondono, rimarranno scoperte.
8. Se le due carte girate non corrispondono, verranno girate nuovamente coperte.
9. Continua a girare le carte e cerca di trovare le coppie corrispondenti fino a quando tutte le coppie non sono state trovate.
10. Il gioco termina quando tutte le coppie sono state trovate con successo.
11. Il tuo punteggio e il tempo trascorso verranno registrati e visualizzati alla fine del gioco.

## Funzionalità <a name="features"></a>
### 1. Livelli di difficoltà <a name="difflvl"></a>
- Il gioco offre tre livelli di difficoltà per adattarsi a diverse abilità: Facile, Medio e Difficile. Ogni livello ha una dimensione di griglia e complessità delle carte diverse.
### 2. Memorizzazione dei risultati <a name="resstor"></a>
- Il gioco tiene traccia dei punteggi e dei tempi del giocatore per ogni livello di difficoltà. Ciò consente ai giocatori di monitorare i propri progressi e cercare di migliorare le prestazioni nelle sessioni successive.
### 3. Musica di sottofondo <a name="backmus"></a>
- Goditi il gioco con la musica di sottofondo per migliorare l'atmosfera del gioco. Il gioco offre quattro diversi temi tra cui scegliere, consentendoti di personalizzare la tua esperienza di gioco.
### 4. Selezione del tema <a name="theme"></a>
- Personalizza l'aspetto del gioco selezionando uno dei temi disponibili. Scegli un tema che si adatti alle tue preferenze e aggiungi un tocco visivamente piacevole al gioco.
### 5. Visualizzazione punteggio e timer <a name="timer"></a>
- Durante il gioco, vengono visualizzati il tuo punteggio attuale e il tempo trascorso. Ciò ti permette di tenere traccia delle tue prestazioni e sfidarti a migliorare ad ogni partita.

## Piattaforme supportate <a name="platforms"></a>
- Windows
- Android

## Requisiti di sistema <a name="sysreq"></a>
- Android: Richiede un dispositivo Android con sistema operativo versione 9 o successiva.
- Windows: Richiede un PC Windows con sistema operativo Windows versione 10 o successiva.

## Installazione <a name="installation"></a>
Per installare de gioco Memory sul tuo dispositivo Android, segui [questa guida](https://github.com/GiorgioCitterio/MemoryMAUI/wiki).

## Versione .NET MAUI: <a name="mauiversion"></a>
Il progetto è stato sviluppato utilizzando [.NET MAUI 6](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-6.0), che offre le ultime funzionalità e miglioramenti per la creazione di app multipiattaforma.

## Pacchetti NuGet <a name="nuget"></a>
Il progetto utilizza i seguenti pacchetti NuGet:
- Plugin.Maui.Audio: Utilizzato per la riproduzione di musica di sottofondo nell'app.
- sqlite-net-pc: Utilizzato per la gestione del database SQLite nell'app.
- SQLitePCLRaw.bundle_green: Utilizzato per il supporto al database SQLite.
  
## Cambiamenti/Funzionalità da aggiungere: <a name="todo"></a>
- [x] Database SQLite
- [x] Markdown
- [x] Android
- [x] Gestore audio (facile, medio, difficile)
- [x] Download APK
- [x] Impostazioni
- [x] Versione e codice sorgente
- [x] Icone
- [x] Ridimensionamento immagini
