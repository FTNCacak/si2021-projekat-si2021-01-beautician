function CityToPostCode(city) {

    switch (city) {
        case "Beograd":
            return "11000";

        case "Novi Sad":
            return "21000";
        case "Niš":
            return "18000";
        case "Kragujevac":
            return "34000";
        case "Subotica":
            return "24000";

        case "Zrenjanin":
            return "23000";
        case "Pančevo":
            return "26000";
        case "Čačak":
            return "32000";
        case "Kruševac":
            return "37000";
        case "Kraljevo":
            return "36000";


        case "Novi Pazar":
            return "36300";
        case "Smederevo":
            return "11300";
        case "Leskovac":
            return "16000";
        case "Užice":
            return "31000";
        case "Vranje":
            return "17500";


        case "Valjevo":
            return "14000";
        case "Šabac":
            return "15000";
        case "Sombor":
            return "25000";
        case "Požarevac":
            return "12000";
        case "Pirot":
            return "18300";


        case "Zaječar":
            return "19000";
        case "Kikinda":
            return "23300";
        case "Sremska Mitrovica":
            return "22000";
        case "Jagodina":
            return "35000";
        case "Vršac":
            return "26300";

        case "Bor":
            return "19210";
        case "Prokuplje":
            return "18400";
        case "Loznica":
            return "15300";
        default:
            return "";
    }

}

function dropDownListValueChange(value) {

  
    var zipCode = CityToPostCode(value);
   
    document.getElementById("TextBoxZipCode").value = zipCode;
}

