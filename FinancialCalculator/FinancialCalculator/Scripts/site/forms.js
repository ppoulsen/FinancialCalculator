// For 2 of 3 (P,C,y)
function disableThird() {
    var P = $('#P').val();
    var C = $('#C').val();
    var y = $('#y').val();
    var fillCount = 0;
    if (P)
        fillCount++;
    if (C)
        fillCount++;
    if (y)
        fillCount++;

    if (fillCount == 2) {
        if (!P)
            $('#P').attr('disabled', 'disabled');
        if (!C)
            $('#C').attr('disabled', 'disabled');
        if (!y)
            $('#y').attr('disabled', 'disabled');
    } else {
        if ($('#P').attr('disabled'))
            $('#P').removeAttr('disabled');
        if ($('#C').attr('disabled'))
            $('#C').removeAttr('disabled');
        if ($('#y').attr('disabled'))
            $('#y').removeAttr('disabled');
    }
}

// For P or y
function disableOther() {
    var P = $('#P').val();
    var y = $('#y').val();
    if (P)
        $('#y').attr('disabled', 'disabled');
    else if (y)
        $('#P').attr('disabled', 'disabled');
    else {
        if ($('#P').attr('disabled'))
            $('#P').removeAttr('disabled');
        if ($('#y').attr('disabled'))
            $('#y').removeAttr('disabled');
    }
}

// mM or N
function disableNOrMAndm() {
    var m = $('#m').val();
    var M = $('#M').val();
    var N = $('#N').val();
    if (m || M) {
        $('#N').attr('disabled', 'disabled');
    } else if (N) {
        $('#m').attr('disabled', 'disabled');
        $('#M').attr('disabled', 'disabled');
    } else {
        if ($('#m').attr('disabled'))
            $('#m').removeAttr('disabled');
        if ($('#M').attr('disabled'))
            $('#M').removeAttr('disabled');
        if ($('#N').attr('disabled'))
            $('#N').removeAttr('disabled');
    }
}