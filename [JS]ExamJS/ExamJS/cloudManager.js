function solve(input){
    var i,
        currentRow,
        data = {},
        result = {},
        memory,
        memoryArr,
        extensions,
        name,
        sortedExtensions = [];
    for(i = 0; i < input.length; i+=1) {
        currentRow = input[i].split(' ').filter(Boolean);
        memoryArr = (currentRow[2]).split(/[A-Z]/).filter(Boolean);
        memory = Number(memoryArr[0]);
        extensions = currentRow[1];
        name = currentRow[0];

        if(!data.hasOwnProperty(extensions)){
            data[extensions] = {};
            data[extensions]['files'] = [name];
            data[extensions]['memory'] = memory;
        } else {
            data[extensions]['files'].push(name);
            data[extensions]['files'].sort();
            data[extensions]['memory'] += memory;
        }
    }

    for(var extension in data) {
        sortedExtensions.push(extension);
    }
    sortedExtensions.sort();
    for (var sortedExtension in sortedExtensions) {
        var currentExtension = sortedExtensions[sortedExtension];
        if(data.hasOwnProperty(currentExtension)){
            result[currentExtension] = {};
            result[currentExtension]['files'] = data[currentExtension]['files'];
            result[currentExtension]['memory'] = data[currentExtension]['memory'].toFixed(2);
        }
    }
    console.log(JSON.stringify(result))
}

solve ([ 'sentinel .exe 15MB',
    'zoomIt .msi 3MB',
    'skype .exe 45MB',
    'trojanStopper .bat 23MB',
    'kindleInstaller .exe 120MB',
    'setup .msi 33.4MB',
    'winBlock .bat 1MB' ])