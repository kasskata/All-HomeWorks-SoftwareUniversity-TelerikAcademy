var args = [
    'Milen Georgiev|PHP|2.02|2',
    '  Ivan Petrov | C# Basics | 3.20 | 22',
    'Peter Nikolov | C# | 5.522 | 18',
    'Maria Kirova | C# Basics | 5.40 | 4.5',
    'Stanislav Peev | C# | 4.012 | 15',
    '   Ivan Petrov |    PHP Basics     |     5.120 |6',
    'Ivan Goranov | SQL | 5.926 | 12',
    'Todor Kirov | Databases | 5.50 |0.0000',
    'Maria Ivanova | Java | 5.83 | 37',
    'Milena Ivanova |    C# |   1.823 | 4.5',
    '     Stanislav Peev   |    C#|   4.122    |    15   ',
    'Kiril Petrov |PHP| 5.10 | 6',
    'Ivan Petrov|SQL|5.926|3',
    '      Peter Nikolov   |    Java  |   5.9996    |    9   ',
    'Stefan Nikolov | Java | 4.00 | 9.5',
    'Ivan Goranov | SQL | 5.926 | 12.5',
    'Todor Kirov | Databases | 5.150 |0.0000',
    'Kiril Ivanov | Java | 5.083 | 327',
    'Diana Ivanova |    C# |   1.823 | 4',
    '     Stanislav Peev   |    C#|   4.122    |    15   ',
    'Kiril Petrov |PHP| 5.10 | 6'
];
solve(args);

function solve(args) {
    var lessons = {};
    var stud = {};
    var arr = [];
    for (var i = 0; i < args.length; i++) {
        arr[i] = args[i].split(/\s*\|\s*/g);
        for (var j = 0; j < arr[i].length; j++) {
            arr[i][j] = arr[i][j].trim();
        }

        var grade = Number(arr[i][2]);
        var visits = Number(arr[i][3]);
        var student = arr[i][0];
        var lesson = arr[i][1];

        if (!stud[lesson]) {
            stud[lesson] = {'visited': []};
        }
        if (!lessons[lesson]) {
            lessons[lesson] = {"avgGrade": 0, "avgVisits": 0, "students": []};
        }
        if (lessons[lesson]['students'].indexOf(student) == -1) {
            lessons[lesson]['students'].push(student);
        }
        stud[lesson]["visited"].push(student);
        lessons[lesson]['avgGrade'] += Number(grade);
        lessons[lesson]['avgVisits'] += Number(visits);
    }
    lessons = sortObjectProperties(lessons);
    for (var val in lessons) {
        lessons[val]['students'] = lessons[val]['students'].sort();
        lessons[val]['avgGrade'] = Math.round((lessons[val]['avgGrade'] / stud[val]['visited'].length) * 100) / 100;
        lessons[val]['avgVisits'] = Math.round((lessons[val]['avgVisits'] / stud[val]['visited'].length) * 100) / 100;
    }
    console.log(JSON.stringify(lessons));
    //================================================================
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
//Math.round((lessons[val]['avgGrade'] / stud[val]['visited'].length) * 100)