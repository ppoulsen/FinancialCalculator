function parseField(field) {
    var ret;
    if (field) {
        ret = parseFloat(field);
        if (isNaN(ret))
            ret = 0;
    } else
        ret = 0;

    return ret;
}

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

function checkPCy() {
    var P = $('#P').val();
    var C = $('#C').val();
    var y = $('#y').val();
    var PIsGood = $.isNumeric(P);
    var CIsGood = $.isNumeric(C);
    var yIsGood = $.isNumeric(y);
    if (
        (PIsGood && CIsGood) ||
        (PIsGood && yIsGood) ||
        (CIsGood && yIsGood))
        return true;
    else
        return false;
}

function checkPy() {
    var P = $('#P').val();
    var y = $('#y').val();
    var PIsGood = $.isNumeric(P);
    var yIsGood = $.isNumeric(y);
    if (PIsGood || yIsGood)
        return true;
    else
        return false;
}

function checkNMm() {
    var N = $('#N').val();
    var M = $('#M').val();
    var m = $('#m').val();
    var NIsGood = $.isNumeric(N);
    var MIsGood = $.isNumeric(M);
    var mIsGood = $.isNumeric(m);
    if ((NIsGood) || (MIsGood && mIsGood))
        return true;
    else
        return false;
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