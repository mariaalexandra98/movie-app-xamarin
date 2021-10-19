using MOVIE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOVIE.Services
{
    class FaqService
    {
        public List<Faq> _loadFaqQuestionList()
        {
            List<Faq> faqList = new List<Faq>();
            faqList.Add(new Faq("Ce este MovieUP?", "MovieUP este o aplicatie dedicata fanilor cu scopul de a - i ajuta sa exploreze lumea filmelor si sa decida ce sa urmareasca."));
            faqList.Add(new Faq("De ce ar trebui sa folosesc aplicatia MovieUP ? ","Aplicatia MovieUP va poate ajuta sa alegeti un film pe placul dumneavoastra punandu - va la dispozitie o lista cu cele mai bune filme.MovieUP va ofera si posibilitatea de a va crea un Watchlist cu filmele pe care doriti sa le vizionati mai tarziu."));
            faqList.Add(new Faq("Cum pot cauta un film pe MovieUP? ", "Puteti introduce titlul sau genul filmului in Search Bar-ul prezent in pagina “Movies”."));
            faqList.Add(new Faq("Caut un film, dar nu-mi amintesc titlul.  Cum pot sa-l gasesc?", "In pagina “Movies” exista posibilitatea sa cautati un film dupa titlu sau gen. Daca introduceti un cuvant care se regaseste in titlul filmului atunci acesta va fi prezentat pe ecran, acelasi lucru aplicandu-se si daca introduceti doar genul filmului."));
            faqList.Add(new Faq("Ce este un Watchlist?", "Watchlist reprezinta lista dumneavoastra in care va puteti introduce filmele pe care doriti sa le vizionati. Acesta vine in ajutorul dumneavoastra atunci cand nu vreti sa uitati de un film pe care poate vreti sa-l vizionati mai tarziu."));
            faqList.Add(new Faq("Cum pot adauga un film in Watchlist?", "In pagina “Movies” exista, pentru fiecare film in parte, un buton numit “Add to warchlist” pe care-l puteti folosi pentru a introduce filmul in Watchlist-ul dumneavoastra."));
            faqList.Add(new Faq("Cum pot sterge un film din Watchlist?", "Puteti elimina un film din lista dumneavoastra de urmarire dand clic pe butonul din dreptul filmului in pagina “Watchlist”.  Daca v-ati razgandit si doriti sa adaugati iar, trebuie doar sa faceti clic pe butonul „Add to watchlist” din nou din pagina  “Movies”."));
            faqList.Add(new Faq("Cum pot gasi filmele pe care le-am adaugat la Watchlist?", "Pentru a naviga la lista dumneavoastra de urmarire selectati “Watchlist” din bara de navigare."));
            faqList.Add(new Faq("Unde pot gasi noile filme aparute?", "Aveti posibilitatea de a vedea ce filme au aparut recent in pagina “Hot Release” din bara de navigare."));
            faqList.Add(new Faq("Ce reprezita pagina “Graphic”?", "Pagina “Graphic” va este prezentata cu scopul de a va arata situatia filmelor in functie de scor, popularitate si incasari."));

            return faqList;
        }
    }
}
