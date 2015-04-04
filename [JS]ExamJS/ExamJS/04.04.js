var args = [
    'sentinel .exe 15MB',
    'zoomIt .msi 3MB',
    'skype .exe 45MB',
    '    trojanStopper    .bat 23MB',
    'kindleInstaller .exe 120MB',
    'setup .msi 33.4MB',
    'winBlock .bat 1MB'
];
solve(args);

function solve(args) {
    var extensions = {};
    var arr = [];
    for (var i = 0; i < args.length; i++) {
        arr[i] = args[i].split(/\s+/g).filter(Boolean);

        var program = arr[i][0];
        var ext = arr[i][1];

        var mb = parseFloat(arr[i][2]);
        if (!extensions[ext]) {
            extensions[ext] = {"files":[],"memory":0};
        }
        if (extensions[ext]['files'].indexOf(program) == -1) {
            extensions[ext]['files'].push(program);
            extensions[ext]['memory']+=Number(mb);
        }
    }
    extensions = sortObjectProperties(extensions);
    for (var val in extensions) {
        extensions[val]['files'] = extensions[val]['files'].sort();
        extensions[val]['memory'] = extensions[val]['memory'].toFixed(2);
    }
    console.log(JSON.stringify(extensions));
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
//{
// ".bat":{"files":["trojanStopper","winBlock"],"memory":"24.00"},
// ".exe":{"files":["kindleInstaller","sentinel","skype"],"memory":"180.00"},
// ".msi":{"files":["setup","zoomIt"],"memory":"36.40"}}
