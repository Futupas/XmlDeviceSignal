var devices = [];
var signals = [];

var xhr1 = new XMLHttpRequest();
xhr1.open('GET', '/GetDevices', false);
xhr1.send();
if (xhr1.status != 200) {
    alert( xhr1.status + ': ' + xhr1.statusText );
} else {
    var data = JSON.parse(xhr1.responseText);
    devices = data;
}


var xhr2 = new XMLHttpRequest();
xhr2.open('GET', '/GetSignals', false);
xhr2.send();
if (xhr2.status != 200) {
    alert(xhr2.status + ': ' + xhr2.statusText);
} else {
    var data = JSON.parse(xhr2.responseText);
    signals = data;
}

var table = document.createElement('table');
var tr = document.createElement('tr');
tr.appendChild(document.createElement('td'));
for (var j = 0; j < devices.length; j++) {
    var td = document.createElement('td');
    td.innerText = devices[j].name;
    tr.appendChild(td);
}
table.appendChild(tr);
for(var i = 0; i < signals.length; i++) {
    var tr = document.createElement('tr');
    tr.setAttribute('signalid', signals[i].id);
    var td = document.createElement('td');
    td.innerText = signals[i].name;
    tr.appendChild(td);
    for (var j = 0; j < devices.length; j++) {
        var td = document.createElement('td');
        var input = document.createElement('input');
        input.type = 'checkbox';
        input.setAttribute('deviceid', devices[j].id);
        td.appendChild(input);
        tr.appendChild(td);
    }
    table.appendChild(tr);
}
document.body.appendChild(table);

function SendData () {
    for (var i = 0; i < signals.length; i++) {
        var sigrow = document.querySelector('table tr[signalid="' + signals[i].id + '"]');
        var checked = sigrow.querySelectorAll('td > input[type="checkbox"][deviceid]:checked');
        signals[i].devices = [];
        for(var j = 0; j < checked.length; j++)
            signals[i].devices.push(devices.filter((e) => { return (e.id == checked[j].getAttribute('deviceid')*1); })[0]);
    }
    var signals_str = JSON.stringify(signals);
    console.log(signals);
    var xhr = new XMLHttpRequest();
    xhr.open('GET', '/SetSignals?signals='+signals_str, false);
    xhr.send();
    if (xhr.status != 200) {
        alert(xhr.status + ': ' + xhr.statusText);
    } else {
        // console.log(xhr.responseText);
        var ael = document.createElement('a');
        ael.setAttribute('href', 'data:text/plain;charset=utf-8,' + encodeURIComponent(xhr.responseText));
        ael.setAttribute('download', 'signals.xml');

        ael.style.display = 'none';
        document.body.appendChild(ael);

        ael.click();

        document.body.removeChild(ael);
    }
}