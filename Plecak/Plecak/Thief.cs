using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plecak
{
    class Thief
    {
        public ListOfElements LOE;
        public Backpack BP = new Backpack();

        //public int weightMin { get; set; }
        //public int weightMax { get; set; }
        //public int priceMin { get; set; }
        //public int priceMax { get; set; }
        //public int numberOfElements { get; set; }
        public int backpackSize { get; set; }
        private int backpackSpaceLeft { get; set; }

        public Thief() { }
        public Thief(ListOfElements list, int backpackSize)
        {
            LOE = list;
            this.backpackSize = backpackSize;
            backpackSpaceLeft = backpackSize;
        }


        // algorytm zachłanny zwracający załadowany plecak przez elementy od najlżejszych
        public void n_element_min_weight()
        {
            LOE = this.bubblesort_min_weight(LOE);
            for(int i = 0; i < LOE.Count; i++)
            {
                while (backpack_space_left(LOE[i]) == true)
                {
                    BP.Add(LOE[i]);
                    backpackSpaceLeft -= LOE[i].weight;
                }
            }
        }


        //public void quicksort(ListOfElements list, int left, int right)
        //{
        //    int i = left;
        //    int j = right;
        //    int pivot;
        //}


        //sprawdzanie czy coś jeszcze do plecaka wejdzie, zwraca true jeżeli wejdzie
        private bool backpack_space_left(Element element)
        {
            if (backpackSpaceLeft >= element.weight)
            {
                return true;
            }
            return false;
        }

        //sortowanie listy po masie, od najmniejszej do największej
        public ListOfElements bubblesort_min_weight(ListOfElements list)
        {
            bool koniec = false;
            ListOfElements pivot = new ListOfElements();
            pivot.Add(new Element(0, 0));

            for(int i = 0; i < list.Count; i++)
            {
                koniec = true;
                for(int j = 1; j < list.Count; j++)
                {
                    if(list[j - 1].weight > list[j].weight)
                    {
                        pivot[0] = list[j - 1];

                        list[j - 1] = list[j];

                        list[j] = pivot[0];
                        koniec = false;
                    }
                }
                if (koniec == true) ;
                break;

            }
            return list;
        }

        //sortuje po cenie, od najdrożyszej do najtańszej
        public void bubblesort_max_price(ListOfElements list)
        {
            bool koniec = false;
            ListOfElements pivot = new ListOfElements();
            pivot.Add(new Element(0, 0));

            for (int i = 0; i < list.Count; i++)
            {
                koniec = true;
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j - 1].price < list[j].price)
                    {
                        pivot[0] = list[j - 1];

                        list[j - 1] = list[j];

                        list[j] = pivot[0];
                        koniec = false;
                    }
                }
                if (koniec == true)
                    break;

            }
        }

        //sortowanie elementów po cena / waga
        public void bubblesort(ListOfElements list)
        {
            
            bool koniec = false;
            ListOfElements pivot = new ListOfElements();
            pivot.Add(new Element(0, 0));

            for (int i = 0; i < list.Count; i++)
            {
                koniec = true;
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j - 1].price / list[j - 1].weight < list[j].price / list[j].weight)
                    {
                        pivot[0].price = list[j].price;
                        pivot[0].weight = list[j].weight;

                        list[j].price = list[j - 1].price;
                        list[j].weight = list[j - 1].weight;

                        list[j - 1].price = pivot[0].price;
                        list[j - 1].weight = pivot[0].weight;

                        koniec = false;
                    }
                }

                if (koniec == true)
                    break;
            }
                        
            LOE = list;
        }
    }
}
