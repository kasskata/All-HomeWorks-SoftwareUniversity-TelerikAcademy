var input = [
    "Levski / CSKA: 0-2",
    "Pavlikeni / Loko Gorna: 4-2",
    "Loko Gorna / Levski: 1-4",
    "Litex / Loko Gorna: 0-0",
    "Beroe / Botev Plovdiv: 2-1",
    "Loko Gorna / Beroe: 3-1",
    "Pavlikeni / Ludogorets: 0-2",
    "Loko Sofia / Litex: 0-2",
    "Pavlikeni / Marek: 1-1",
    "Litex / Levski: 0-0",
    "Beroe / Litex: 3-2",
    "Litex / Beroe: 1-0",
    "Ludogorets / Litex: 3-0",
    "Litex / Ludogorets: 1-0",
    "CSKA / Beroe: 1-0",
    "Botev Plovdiv / CSKA: 1-1",
    "Ludogorets / Loko Sofia: 1-0",
    "Litex / CSKA: 0-1",
    "Marek / Haskovo: 0-1",
    "Levski / Loko Gorna: 1-1"
];
solve(input);

function solve(args) {
    var meets = [];
    var teams = {};

    for (var i = 0; i < args.length; i++) {
        meets[i] = [];
        meets[i] = args[i].split(/[/:-]/g).filter(Boolean);
        for (var j = 0; j < meets[i].length; j++) {
            meets[i][j] = meets[i][j].trim();
        }
    }
    for (var i = 0; i < meets.length; i++) {
        for (var j = 0; j < meets[i].length; j++) {
            if (j == 0) {
                if (!teams[meets[i][j]]) {
                    teams[meets[i][j]] = {"goalsScored": 0, "goalsConceded": 0, "matchesPlayedWith": []};
                }
            } else if (j == 1) {
                if (!teams[meets[i][j]]) {
                    teams[meets[i][j]] = {"goalsScored": 0, "goalsConceded": 0, "matchesPlayedWith": []};
                }
            } else if (j == 2) {
                teams[meets[i][0]]['goalsScored'] += Number(meets[i][j]);
                teams[meets[i][1]]['goalsConceded'] += Number(meets[i][j]);
                if(teams[meets[i][0]]["matchesPlayedWith"].indexOf(meets[i][1])==-1){
                    teams[meets[i][0]]["matchesPlayedWith"].push(meets[i][1]);
                }
                if(teams[meets[i][1]]["matchesPlayedWith"].indexOf(meets[i][0])==-1){
                    teams[meets[i][1]]["matchesPlayedWith"].push(meets[i][0]);
                }

            } else if (j == 3) {
                teams[meets[i][0]]['goalsConceded'] += Number(meets[i][j]);
                teams[meets[i][1]]['goalsScored'] += Number(meets[i][j]);
            }
        }
    }
    teams = sortObjectProperties(teams);
    for (var team in teams) {
        teams[team]['matchesPlayedWith'].sort();
    }
    console.log(JSON.stringify(teams));
    //___________________________________________________________
    function sortObjectProperties(obj) {
        var keysSorted = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < keysSorted.length; i++) {
            var key = keysSorted[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }
}

