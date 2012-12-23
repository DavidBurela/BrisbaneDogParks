using System;
using System.Collections.Generic;
using System.Linq;
using BrisbaneDogParks.RT.Helpers;
using BrisbaneDogParks.RT.Models;

namespace BrisbaneDogParks.RT.ViewModels
{
    public class MainViewModel
    {
        public SortedObservableCollection<LocationData> Locations { get; set; }

        public MainViewModel()
        {
            Locations = new SortedObservableCollection<LocationData>();

            CreateData();
        }

        private void CreateData()
        {
            Locations.Add(new LocationData { LocationName = "7th Brigade Park", Address = "Hamilton Rd, Chermside", Latitude = -27.38123113, Longitude = 153.0436597 });
            Locations.Add(new LocationData { LocationName = "Abbeville Street Park", Address = "Abbeville St, Upr Mt Gravatt", Latitude = -27.5445799, Longitude = 153.0893523 });
            Locations.Add(new LocationData { LocationName = "Albert Bishop Park", Address = "Hedley Ave, Nundah", Latitude = -27.40528155, Longitude = 153.0673599 });
            Locations.Add(new LocationData { LocationName = "Amelia Park", Address = "Mccord St, Gordon Park", Latitude = -27.4163804, Longitude = 153.0329195 });
            Locations.Add(new LocationData { LocationName = "Anzac Park", Address = "Mt Coot-Tha Rd, Toowong", Latitude = -27.48031883, Longitude = 152.9771637 });
            Locations.Add(new LocationData { LocationName = "Arbor Street Park", Address = "Tramway St, Ferny Grove", Latitude = -27.40606994, Longitude = 152.939053 });
            Locations.Add(new LocationData { LocationName = "Archer Street Park", Address = "Archer St, Gordon Park", Latitude = -27.42149, Longitude = 153.02515 });
            Locations.Add(new LocationData { LocationName = "Bancroft Park", Address = "Kelvin Grove Rd, Kelvin Grove", Latitude = -27.44331477, Longitude = 153.006709 });
            Locations.Add(new LocationData { LocationName = "Barrett Street Park (Water Reserve)", Address = "Snooker St, Bracken Ridge", Latitude = -27.32178388, Longitude = 153.0323962 });
            Locations.Add(new LocationData { LocationName = "Barungwarra Bushland Reserve", Address = "Bald Hills-Burpengary Rd, Bald Hills", Latitude = -27.30319777, Longitude = 153.0151797 });
            Locations.Add(new LocationData { LocationName = "Beanland Street Park", Address = "Loffs Rd, Jamboree Hts", Latitude = -27.55198509, Longitude = 152.9305048 });
            Locations.Add(new LocationData { LocationName = "Berkshire Crescent Park", Address = "Berkshire Cres, Wishart", Latitude = -27.54947514, Longitude = 153.0995154 });
            Locations.Add(new LocationData { LocationName = "Beryl Roberts Park", Address = "Baroda St, Coopers Plains", Latitude = -27.56555534, Longitude = 153.0440768 });
            Locations.Add(new LocationData { LocationName = "Bill Lamond Park", Address = "Andrew St, Lota", Latitude = -27.47231536, Longitude = 153.185764 });
            Locations.Add(new LocationData { LocationName = "Blackbutt Place Park", Address = "Blackbutt Pl, Brookfield", Latitude = -27.50369, Longitude = 152.93016 });
            Locations.Add(new LocationData { LocationName = "Blue Gum Park", Address = "Kakadu Crct, Zillmere", Latitude = -27.34987, Longitude = 153.03526 });
            Locations.Add(new LocationData { LocationName = "Booker Place Park", Address = "Birkin Rd, Bellbowrie", Latitude = -27.56433113, Longitude = 152.8952035 });
            Locations.Add(new LocationData { LocationName = "Boondall Park", Address = "Sandgate Rd, Boondall", Latitude = -27.33829777, Longitude = 153.0564819 });
            Locations.Add(new LocationData { LocationName = "Boorabbin Picnic Ground", Address = "Mt Gravatt-Capalaba Rd, Wishart", Latitude = -27.55313162, Longitude = 153.1111672 });
            Locations.Add(new LocationData { LocationName = "Boyd Park", Address = "Boyd Rd, Nundah", Latitude = -27.4009, Longitude = 153.05785 });
            Locations.Add(new LocationData { LocationName = "Brookbent Road Park", Address = "Gooderham Rd, Pallara", Latitude = -27.6089, Longitude = 153.01056 });
            Locations.Add(new LocationData { LocationName = "Bulimba Riverside Park", Address = "Addison Ave, Bulimba", Latitude = -27.30319777, Longitude = 153.0151797 });
            Locations.Add(new LocationData { LocationName = "Bulimba Riverside Park", Address = "Addison Ave, Bulimba", Latitude = -27.41291502, Longitude = 153.0566716 });
            Locations.Add(new LocationData { LocationName = "C.J.Greenfield Complex Park", Address = "Kimberley St, Richlands", Latitude = -27.57667006, Longitude = 152.9607007 });
            Locations.Add(new LocationData { LocationName = "Canterbury Park", Address = "Feuerriegel Rd, Bald Hills", Latitude = -27.30671034, Longitude = 153.0078125 });
            Locations.Add(new LocationData { LocationName = "Carindale Rec Reserve", Address = "Bedivere St, Carindale", Latitude = -27.49841445, Longitude = 153.1099479 });
            Locations.Add(new LocationData { LocationName = "Colmslie Reserve", Address = "Lytton Rd, Morningside", Latitude = -27.45034046, Longitude = 153.0840544 });
            Locations.Add(new LocationData { LocationName = "Crosby Park", Address = "Crosby Rd, Albion", Latitude = -27.43612043, Longitude = 153.0477893 });
            Locations.Add(new LocationData { LocationName = "Cubberla Creek Reserve", Address = "Fig Tree Pocket Rd, Chapel Hill", Latitude = -27.51360702, Longitude = 152.9505774 });
            Locations.Add(new LocationData { LocationName = "Curlew Park", Address = "Curlew St, Sandgate", Latitude = -27.32685121, Longitude = 153.0734281 });
            Locations.Add(new LocationData { LocationName = "D.M.Henderson Park", Address = "Mccullough St, Macgregor", Latitude = -27.56942539, Longitude = 153.0725049 });
            Locations.Add(new LocationData { LocationName = "Dash Street Park", Address = "Duggan St, Keperra", Latitude = -27.40927235, Longitude = 152.956299 });
            Locations.Add(new LocationData { LocationName = "Decker Park", Address = "Twenty-Fifth Ave, Brighton", Latitude = -27.2865181, Longitude = 153.0634786 });
            Locations.Add(new LocationData { LocationName = "Delapine Place Park", Address = "Delapine Pl, Svtn Mile Rocks", Latitude = -27.54711284, Longitude = 152.9607619 });
            Locations.Add(new LocationData { LocationName = "Downfall Creek Reserve", Address = "Jefferis St, Virginia", Latitude = -27.38309469, Longitude = 153.0580824 });
            Locations.Add(new LocationData { LocationName = "Durella Street Park", Address = "Blunder Rd, Durack", Latitude = -27.59767272, Longitude = 152.9785885 });
            Locations.Add(new LocationData { LocationName = "Dutton Park", Address = "Gladstone Rd, Dutton Park", Latitude = -27.49698383, Longitude = 153.0263426 });
            Locations.Add(new LocationData { LocationName = "Elanora Park", Address = "Saunders Pl, Wynnum", Latitude = -27.42732274, Longitude = 153.1693386 });
            Locations.Add(new LocationData { LocationName = "Endiandra Street Park", Address = "Algester Rd, Algester", Latitude = -27.61727047, Longitude = 153.0301517 });
            Locations.Add(new LocationData { LocationName = "Englefield Road Park (Nos.35-47)", Address = "Mabel St, Oxley", Latitude = -27.55719132, Longitude = 152.9754562 });
            Locations.Add(new LocationData { LocationName = "Evelyn Road Park", Address = "Kianawah Rd, Wynnum West", Latitude = -27.45157155, Longitude = 153.1457458 });
            Locations.Add(new LocationData { LocationName = "Fairfield Park", Address = "Fairfield Rd, Fairfield", Latitude = -27.50354713, Longitude = 153.0264657 });
            Locations.Add(new LocationData { LocationName = "Faulkner Park", Address = "Leybourne St, Graceville", Latitude = -27.51915828, Longitude = 152.98634 });
            Locations.Add(new LocationData { LocationName = "Fauna Parade Park", Address = "Boobook St, Rocklea", Latitude = -27.55003374, Longitude = 153.0133194 });
            Locations.Add(new LocationData { LocationName = "George Scarlett Park", Address = "Pratten St, Corinda", Latitude = -27.5483724, Longitude = 152.984655 });
            Locations.Add(new LocationData { LocationName = "Gilbert Park", Address = "Fulcher Rd, Red Hill", Latitude = -27.44925534, Longitude = 152.9971665 });
            Locations.Add(new LocationData { LocationName = "Grange Forest Park", Address = "Raymont Rd, Grange", Latitude = -27.41516517, Longitude = 153.0095095 });
            Locations.Add(new LocationData { LocationName = "Green Hill Reservoir Park", Address = "Russell Tce, Chapel Hill", Latitude = -27.49514748, Longitude = 152.9585531 });
            Locations.Add(new LocationData { LocationName = "Greenways Esplanade Park", Address = "Greenways Esp, Parkinson", Latitude = -27.63607721, Longitude = 153.0198072 });
            Locations.Add(new LocationData { LocationName = "Grey Gum Park", Address = "Rode Rd, Stafford Hts", Latitude = -27.39229732, Longitude = 153.004157 });
            Locations.Add(new LocationData { LocationName = "Gus Davies Park", Address = "Charlock Rd, Bald Hills", Latitude = -27.3071515, Longitude = 153.0200719 });
            Locations.Add(new LocationData { LocationName = "Gympie Rd (No 1) Park", Address = "Park Tce, Kedron", Latitude = -27.42045246, Longitude = 153.0311401 });
            Locations.Add(new LocationData { LocationName = "Hamish Street Park", Address = "Murphy St, Calamvale", Latitude = -27.61853946, Longitude = 153.0447264 });
            Locations.Add(new LocationData { LocationName = "Hercules Street Park", Address = "Remora Rd, Hamilton", Latitude = -27.43927111, Longitude = 153.0694852 });
            Locations.Add(new LocationData { LocationName = "Holmead Park", Address = "Ditmas St, Wishart", Latitude = -27.56790653, Longitude = 153.0914884 });
            Locations.Add(new LocationData { LocationName = "Hyde Road Park", Address = "Fairfield Rd, Yeronga", Latitude = -27.51171906, Longitude = 153.0155728 });
            Locations.Add(new LocationData { LocationName = "Jindalee Boat Ramp Park", Address = "Mt Ommaney Dr, Jindalee", Latitude = -27.52883721, Longitude = 152.9297902 });
            Locations.Add(new LocationData { LocationName = "Julie Road Park", Address = "Julie Rd, Carole Park", Latitude = -27.61399065, Longitude = 152.9354013 });
            Locations.Add(new LocationData { LocationName = "Kalinga Park", Address = "Kalinga St, Clayfield", Latitude = -27.40507202, Longitude = 153.0504364 });
            Locations.Add(new LocationData { LocationName = "Kenna Street Park", Address = "Kenna St, Chermside West", Latitude = -27.37859218, Longitude = 153.0123785 });
            Locations.Add(new LocationData { LocationName = "Keralgerie Park", Address = "Richmond Rd, Morningside", Latitude = -27.47354513, Longitude = 153.0794059 });
            Locations.Add(new LocationData { LocationName = "Keryn Place Park", Address = "Mungarie St, Keperra", Latitude = -27.42095089, Longitude = 152.9456007 });
            Locations.Add(new LocationData { LocationName = "Kianawah Park", Address = "Wynnum Rd, Tingalpa", Latitude = -27.47553301, Longitude = 153.1260192 });
            Locations.Add(new LocationData { LocationName = "Kokoda Park", Address = "Tindal St, Gordon Park", Latitude = -27.42199702, Longitude = 153.0274883 });
            Locations.Add(new LocationData { LocationName = "Kookaburra Park - West", Address = "Caringal Dr, Karana Downs", Latitude = -27.54507392, Longitude = 152.8379762 });
            Locations.Add(new LocationData { LocationName = "Mactier Street Park", Address = "Fig Tree Pocket Rd, Fig Tree Pocket", Latitude = -27.53922377, Longitude = 152.9657172 });
            Locations.Add(new LocationData { LocationName = "Marchant Park", Address = "Gympie Rd, Aspley", Latitude = -27.37753311, Longitude = 153.0304708 });
            Locations.Add(new LocationData { LocationName = "Marnham Street Park", Address = "Marnham St, Acacia Ridge", Latitude = -27.5935823, Longitude = 153.0261529 });
            Locations.Add(new LocationData { LocationName = "Martindale Street Park", Address = "Stringybark Dr, Chermside West", Latitude = -27.37773502, Longitude = 153.0030339 });
            Locations.Add(new LocationData { LocationName = "Merri Merri Park", Address = "Greenford St, Chapel Hill", Latitude = -27.48388291, Longitude = 152.940144 });
            Locations.Add(new LocationData { LocationName = "Milton Park", Address = "Milton Rd, Milton", Latitude = -27.47187954, Longitude = 153.0006174 });
            Locations.Add(new LocationData { LocationName = "Monoplane Street Park", Address = "Monoplane St, Ashgrove", Latitude = -27.45243087, Longitude = 152.9743663 });
            Locations.Add(new LocationData { LocationName = "Mulbeam Park", Address = "Muller Rd, Boondall", Latitude = -27.3516, Longitude = 153.0533 });
            Locations.Add(new LocationData { LocationName = "Nathan Road Park", Address = "Nathan Rd, Runcorn", Latitude = -27.58731959, Longitude = 153.0705409 });
            Locations.Add(new LocationData { LocationName = "Neal Macrossan Playground Park", Address = "Caroline St, Paddington", Latitude = -27.46203865, Longitude = 153.0101714 });
            Locations.Add(new LocationData { LocationName = "Newbury Place Park", Address = "Cribb Rd, Carindale", Latitude = -27.52408145, Longitude = 153.1201302 });
            Locations.Add(new LocationData { LocationName = "Norma Croker Park", Address = "Lismore St, Acacia Ridge", Latitude = -27.5868944, Longitude = 153.0143878 });
            Locations.Add(new LocationData { LocationName = "Northey Street Park", Address = "Edgar St, Windsor", Latitude = -27.44359224, Longitude = 153.0266841 });
            Locations.Add(new LocationData { LocationName = "Northgate Reserve", Address = "Nudgee Rd, Northgate", Latitude = -27.39729825, Longitude = 153.0723215 });
            Locations.Add(new LocationData { LocationName = "Northumbria Road Park", Address = "Aberdeen Pde, Boondall", Latitude = -27.35799827, Longitude = 153.0735497 });
            Locations.Add(new LocationData { LocationName = "Nudgee Waterhole Reserve", Address = "Nudgee Rd, Nudgee", Latitude = -27.37571773, Longitude = 153.0932412 });
            Locations.Add(new LocationData { LocationName = "Pat Rafter Park", Address = "Medallion Pl, Carseldine", Latitude = -27.34110764, Longitude = 153.0087854 });
            Locations.Add(new LocationData { LocationName = "Paten Park", Address = "Paten Rd, The Gap", Latitude = -27.45200989, Longitude = 152.9526491 });
            Locations.Add(new LocationData { LocationName = "Perrin Park", Address = "Josling St, Toowong", Latitude = -27.49213809, Longitude = 152.9922049 });
            Locations.Add(new LocationData { LocationName = "Phillip Place Park (Forest Lake)", Address = "Forest Lake Blvd, Forest Lake", Latitude = -27.61897722, Longitude = 152.9722195 });
            Locations.Add(new LocationData { LocationName = "Phillips Place Park (Wakerley)", Address = "Phillips Pl, Wakerley", Latitude = -27.48304257, Longitude = 153.1462326 });
            Locations.Add(new LocationData { LocationName = "Pioneer Crescent Park", Address = "Pioneer Cres, Bellbowrie", Latitude = -27.56163049, Longitude = 152.8720795 });
            Locations.Add(new LocationData { LocationName = "Powerhouse Park", Address = "Lamington St, New Farm", Latitude = -27.46750848, Longitude = 153.0541894 });
            Locations.Add(new LocationData { LocationName = "Preston Road Park", Address = "Fursden Rd, Cannon Hill", Latitude = -27.49351422, Longitude = 153.1185684 });
            Locations.Add(new LocationData { LocationName = "Raymond Park", Address = "Wellington Rd, Kangaroo Point", Latitude = -27.48147963, Longitude = 153.0397817 });
            Locations.Add(new LocationData { LocationName = "Real Park", Address = "Heath St, East Brisbane", Latitude = -27.48066416, Longitude = 153.0490232 });
            Locations.Add(new LocationData { LocationName = "Richlands Depot Park", Address = "Government Rd, Inala", Latitude = -27.60017814, Longitude = 152.9592939 });
            Locations.Add(new LocationData { LocationName = "Roy Harvey Park", Address = "Byth St, Stafford", Latitude = -27.411202, Longitude = 153.0068891 });
            Locations.Add(new LocationData { LocationName = "Salisbury Recreation Reserve", Address = "Evans Rd, Salisbury", Latitude = -27.54639106, Longitude = 153.037597 });
            Locations.Add(new LocationData { LocationName = "Sedgley Park", Address = "Alderson St, Alderley", Latitude = -27.42899638, Longitude = 153.0049779 });
            Locations.Add(new LocationData { LocationName = "Shaftesbury Street Park", Address = "Shaftesbury St, Tarragindi", Latitude = -27.51953186, Longitude = 153.0417092 });
            Locations.Add(new LocationData { LocationName = "Shand Street Park (No.100)", Address = "Shand St, Stafford", Latitude = -27.41436194, Longitude = 153.0039454 });
            Locations.Add(new LocationData { LocationName = "Shaw Estate Park", Address = "Shaw Rd, Wavell Heights", Latitude = -27.40130165, Longitude = 153.0400868 });
            Locations.Add(new LocationData { LocationName = "South Brisbane Riverside Lands Park", Address = "Jane St, West End", Latitude = -27.47425369, Longitude = 153.0076218 });
            Locations.Add(new LocationData { LocationName = "Stannard Road Park", Address = "Stannard Rd, Manly West", Latitude = -27.46140385, Longitude = 153.1689959 });
            Locations.Add(new LocationData { LocationName = "Tallowwood Place Park", Address = "Tallowwood Pl, Bridgeman Downs", Latitude = -27.36634155, Longitude = 152.9973607 });
            Locations.Add(new LocationData { LocationName = "Teralba Park", Address = "Pullen Rd, Everton Park", Latitude = -27.40816775, Longitude = 152.9833594 });
            Locations.Add(new LocationData { LocationName = "Thistle Street Park (No.74)", Address = "Thistle St, Gordon Park", Latitude = -27.42045246, Longitude = 153.0311401 });
            Locations.Add(new LocationData { LocationName = "Tigris Street Park", Address = "Tigris St, Riverhills", Latitude = -27.55828279, Longitude = 152.9084487 });
            Locations.Add(new LocationData { LocationName = "Tones Road Park", Address = "Tones Rd, Mansfield", Latitude = -27.53096948, Longitude = 153.1095144 });
            Locations.Add(new LocationData { LocationName = "Tuckeroo Park", Address = "Nudgee Rd, Nudgee Beach", Latitude = -27.35121561, Longitude = 153.1056366 });
            Locations.Add(new LocationData { LocationName = "Upper Kedron Recreation Reserve", Address = "Cemetery Rd, Upr Kedron", Latitude = -27.41222826, Longitude = 152.9231671 });
            Locations.Add(new LocationData { LocationName = "Vectis Street Park", Address = "Halifax St, Norman Park", Latitude = -27.48068779, Longitude = 153.0580019 });
            Locations.Add(new LocationData { LocationName = "Victoria Park", Address = "Gilchrist Ave, Herston", Latitude = -27.45456139, Longitude = 153.0261099 });
            Locations.Add(new LocationData { LocationName = "Wally Bourke Park", Address = "Kate St, Gordon Park", Latitude = -27.42132842, Longitude = 153.0300275 });
            Locations.Add(new LocationData { LocationName = "Wally Tate Park", Address = "Beenleigh Rd, Kuraby", Latitude = -27.60216747, Longitude = 153.0910203 });
            Locations.Add(new LocationData { LocationName = "Wembley Park", Address = "Jackson St, Coorparoo", Latitude = -27.4896412, Longitude = 153.063372 });
            Locations.Add(new LocationData { LocationName = "Windermere Avenue Park (No.82)", Address = "Sinnamon Rd, Sinnamon Park", Latitude = -27.53895003, Longitude = 152.9554679 });
            Locations.Add(new LocationData { LocationName = "Wittonga Park", Address = "Hilder Rd, The Gap", Latitude = -27.43986803, Longitude = 152.9327001 });
            Locations.Add(new LocationData { LocationName = "Wolston Creek Bushland Reserve", Address = "Riverpoint Blvd, Riverhills", Latitude = -27.56374102, Longitude = 152.9030954 });
            Locations.Add(new LocationData { LocationName = "Woolloongabba Rotary Park", Address = "Camberwell St, East Brisbane", Latitude = -27.49039831, Longitude = 153.0429839 });
            Locations.Add(new LocationData { LocationName = "Yeronga Memorial Park", Address = "Park Rd, Yeronga", Latitude = -27.51954535, Longitude = 153.0223786 });
            Locations.Add(new LocationData { LocationName = "Yimbun Park", Address = "Mccullough St, Sunnybank", Latitude = -27.57424598, Longitude = 153.0730349 });
        }
    }
}
