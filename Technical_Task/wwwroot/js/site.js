//// Step 1
//var rowCount1 = 0;
//document.getElementById('ButtonStep1').addEventListener('click', function () {
//    var table = document.getElementById('dynamic-table1');
//    var newRow = document.createElement('tr');
//    newRow.className = 'trCSS';

//    var checkboxCell = document.createElement('td');
//    var checkbox = document.createElement('input');
//    checkbox.type = 'checkbox';
//    checkbox.name = 'Step1CheckBox';
//    checkbox.classList.add('step-checkbox');
//    checkbox.value = '';
//    checkbox.addEventListener('change', handleCheckboxChange1);
//    checkboxCell.appendChild(checkbox);
//    newRow.appendChild(checkboxCell);

//    var textboxCell = document.createElement('td');
//    var textbox = document.createElement('input');
//    textbox.name = 'Step1Value';
//    textbox.className = 'form-control Inputcss';
//    textbox.value = 0;
//    textboxCell.appendChild(textbox);
//    newRow.appendChild(textboxCell);

//    table.appendChild(newRow);
//    rowCount1++;
//    document.getElementById('row-count1').value = rowCount1;
//});

//document.getElementById('Step1CheckBoxSelectAll').addEventListener('change', function () {
//    var checkboxes = document.querySelectorAll('input[name="Step1CheckBox"]');
//    checkboxes.forEach(function (checkbox) {
//        checkbox.checked = document.getElementById('Step1CheckBoxSelectAll').checked;
//    });
//    handleCheckboxChange1();
//});

//function handleCheckboxChange1() {
//    const checkboxes = document.querySelectorAll('.step-checkbox');
//    let checkedValues = [];
//    let checkedCount = 0;

//    checkboxes.forEach((checkbox) => {
//        if (checkbox.checked) {
//            let row = checkbox.closest('tr');
//            let textbox = row.querySelector('input[name="Step1Value"]');
//            if (textbox) {
//                checkedValues.push(parseFloat(textbox.value) || 0);
//                checkedCount++;
//            }
//        }
//    });

//    document.getElementById('output1').innerHTML = `
//                <p>Select Items: ${checkedCount}, Total Number: ${checkedValues.reduce((a, b) => a + b, 0)}</p>`;
//}

//handleCheckboxChange1();

//// Step 2
//var rowCount2 = 0;
//document.getElementById('ButtonStep2').addEventListener('click', function () {
//    var table = document.getElementById('dynamic-table2');
//    var newRow = document.createElement('tr');
//    newRow.className = 'trCSS';

//    var checkboxCell = document.createElement('td');
//    var checkbox = document.createElement('input');
//    checkbox.type = 'checkbox';
//    checkbox.name = 'Step2CheckBox';
//    checkbox.classList.add('step2-checkbox');
//    checkbox.value = '';
//    checkbox.addEventListener('change', handleCheckboxChange2);
//    checkboxCell.appendChild(checkbox);
//    newRow.appendChild(checkboxCell);

//    var textboxCell = document.createElement('td');
//    var textbox = document.createElement('input');
//    textbox.name = 'Step2Value';
//    textbox.className = 'form-control Inputcss';
//    textbox.value = '';
//    textboxCell.appendChild(textbox);
//    newRow.appendChild(textboxCell);

//    table.appendChild(newRow);
//    rowCount2++;
//    document.getElementById('row-count2').value = rowCount2;
//});

//document.getElementById('Step2CheckBoxSelectAll').addEventListener('change', function () {
//    var checkboxes = document.querySelectorAll('input[name="Step2CheckBox"]');
//    checkboxes.forEach(function (checkbox) {
//        checkbox.checked = document.getElementById('Step2CheckBoxSelectAll').checked;
//    });
//    handleCheckboxChange2();
//});

//function handleCheckboxChange2() {
//    const checkboxes = document.querySelectorAll('.step2-checkbox');
//    let checkedValues = [];
//    let checkedCount = 0;

//    checkboxes.forEach((checkbox) => {
//        if (checkbox.checked) {
//            let row = checkbox.closest('tr');
//            let textbox = row.querySelector('input[name="Step2Value"]');
//            if (textbox) {
//                checkedValues.push(parseFloat(textbox.value) || 0);
//                checkedCount++;
//            }
//        }
//    });

//    document.getElementById('output2').innerHTML = `
//                <p>Select Items: ${checkedCount}, Total Number: ${checkedValues.reduce((a, b) => a + b, 0)}</p>`;
//}

//handleCheckboxChange2();