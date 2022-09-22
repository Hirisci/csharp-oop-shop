using csharp_oop_shop;
using System.Runtime.ConstrainedExecution;
using System;















//Acqua(massimo 1.5L)
    //Product->Liquid
        //->scelta contenitore
        //->riempire fino a max
        //->Imacchettare

//Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
    //Product->vegetable
        //->scelta contenitore

//Elettrodomestico
    //Product->Machine

//Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)
    //Product->food



//metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.
//metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo.
//metodo svuota() che rimuove tutta l’acqua dalla bottiglia.


//metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto (se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di stampare il “codice - nome”, l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice e al nome dell’acqua, anche la sua sorgente, il ph e i litri contenuti.
//un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti come 3.785 nel modo corretto come visto in classe).
//Ricordatevi di creare questi metodi in maniera responsabile, in modo che non rendono “incoerente” lo stato dei vostri oggetti (ad esempio non posso bere più dei litri contenuti nella bottiglia, o non posso riempire più di tot una bottiglia!).
//E così via per tutti gli altri elementi qui sopra riportati, provate a pensare attributi e metodi che potrebbero servire ai vostri prodotti specializzati Acqua, sacchetto di frutta a pezzi, elettrodomestici e cibo in scatola.
//Al solito usate opportunamente i livelli di accesso (public, private, protected o altro se necessario), i costruttori, i metodi getter e setter (o le properties) ed eventuali altri metodi di “utilità“.
//Pensate anche se avete bisogno di eventuali metodi statici o attributi statici (ad esempio potrebbero essere i limiti dei vostri oggetti ), e ad eventuali override e overload di metodi come visto per Acqua.
//Una volta finite più o meno le vostre classi, nel Program.cs, provate a testare un pò i vostri prodotti specializzati, osservando come i metodi della classe generica prodotto e quelli più specifici vengono richiamati e siano disponibili.
//Buon lavoro!