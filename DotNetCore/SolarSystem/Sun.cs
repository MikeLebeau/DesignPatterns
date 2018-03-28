using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
   public class Sun
   {
       private static Sun theSun;
       private Sun(){}

       public static Sun getInstance() {
           if(theSun == null) {
               theSun = new Sun();
           }

           return theSun;
       }
   }
}