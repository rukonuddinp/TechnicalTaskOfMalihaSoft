
function addStep1Row() {
    $.ajax({
        url: '/Steps/AddStep1Row',
        method: 'POST',
        dataType: 'json',
        success: function (data) {
            location.reload();
        },
        error: function (xhr, status, error) {
           
        }
    });
}


function addStep2Row() {
    $.ajax({
        url: '/Steps/AddStep2Row',
        method: 'POST',
        dataType: 'json',
        success: function (data) {
            location.reload();
        },
        error: function (xhr, status, error) {

        }
    });
}

$(document).ready(function () {

    function saveData(id, value, type) {
       
        let data;

        if (typeof value === 'boolean') {
            data = { Id: id, BoolValue: value, Type: type };
        } else {
            data = { Id: id, Value: value, Type: type };
        }


        $.ajax({
            url: '/Steps/UpdateRow',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            success: function (response) {
                updateOutput();
                updateOutput2();
                location.reload();
            },
            error: function (xhr, status, error) {
                console.error('Error saving data:', error);
            }
        });
    }
    function updateOutput() {
        let selectedCount = 0;
        let sum = 0;
        debugger;
        $('.step1-checkbox:checked').each(function () {
            debugger;
            const id = $(this).attr('id').split('-')[2];
            const value = parseInt($(`#step1-input-${id}`).val(), 10);

            if (!isNaN(value)) {
                selectedCount++;
                sum += value;
            }
        });

        $('#ViewStep1ValuSum').html(`Selected <strong>${selectedCount}</strong> Items and Total Number: <strong>${sum}</strong>`);

    }

    function updateOutput2() {
        let selectedCount = 0;
        let sum = 0;
        let indices = [];  // Array to collect indices
        
        debugger;
        $('.step2-checkbox:checked').each(function () {
            debugger;
            const id = $(this).attr('id').split('-')[2];
            const value = parseInt($(`#step2-input-${id}`).val(), 10);
            const index = $(this).attr('name');  // Use name attribute to get the index directly

            if (!isNaN(value)) {
                selectedCount++;
                sum += value;
                indices.push(index);  // Collect indices
            }
        });

        $('#ViewStep2ValuSum').html(`Selected <strong>${selectedCount}</strong> Items, Possition <strong>${indices.join(', ') }</strong> and Total Number: <strong>${sum}</strong>`);

    }

    $('.step1-input').on('change', function () {
        const id = $(this).attr('id').split('-')[2];  // Extract the ID from the element's id
        const value = $(this).val();
        saveData(id, value, 'Step1');
    });

    $('.step2-input').on('change', function () {
        const id = $(this).attr('id').split('-')[2];  // Extract the ID from the element's id
        const value = $(this).val();
        saveData(id, value, 'Step2');
    });

    $('.step1-checkbox').on('change', function () {
        const id = $(this).attr('id').split('-')[2];  // Extract the ID from the element's id
        const value = $(this).is(':checked');
        saveData(id, value, 'Step1Checkbox');
    });
    $('.step2-checkbox').on('change', function () {
        const id = $(this).attr('id').split('-')[2];  // Extract the ID from the element's id
        const value = $(this).is(':checked');
        saveData(id, value, 'Step2Checkbox');
    });
    updateOutput();
    updateOutput2();
});