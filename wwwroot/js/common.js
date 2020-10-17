function isEmpty(value) {
    return value != null && value != undefined && value != "" && value != " ";
}

function dateToEN(date) {
    if (isEmpty(date)) {
        return date.split('/').reverse().join('-');
    }
}

function textCapitalize(text) {
    if (isEmpty(text)) {
        var words = text.toLowerCase().split(" ");
        for (let i = 0; i < words.length; i++) {
            var w = words[i];
            words[i] = w[0].toUpperCase() + w.slice(1);
        }
        return words.join(" ");
    }
}

function lettersOnly(evt) {
    evt = (evt) ? evt : event;
    var charCode = (evt.charCode) ? evt.charCode : ((evt.keyCode) ? evt.keyCode : ((evt.which) ? evt.which : 0));
    if (charCode > 32 && (charCode < 65 || charCode > 90) && (charCode < 97 || charCode > 122)) {
        return false;
    }
    return true;
}

function numberOnly(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
}