using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    class DecisionNode
    {
        // sets out structure of possible paths to go through when interacting with a patient, particularly in resuscitation. 
        // nodes make up a 'decision tree', which sets out the possible paths when interacting with a patient with particular conditions
        // hopefully a major part of the logic for handling user interaction etc?

        // decision tree structured as so:
        // decision node --> any amount of decision nodes (up to 4?) based on user interaction - yes / no
        // decision nodes can have no further interactions, but trigger e.g. death / pat. transfer, etc

        // instantiation of nodes / creation of trees will mostly / always? occur during instantiation of specific classes for conditions,
        // as there is little real use for them otherwise

        // allows talking and asking questions  


    }
}
