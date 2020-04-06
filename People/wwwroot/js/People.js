$(() => {
    var id = 1;
    $("#add-people").on('click', () => {

        $("#people").append("<br/><input id='fname' type='text' name='people[" + id + "].firstname' class='form-control' placeholder='First Name' />" +
            "<input id='lname' type='text' name='people[" + id + "].lastname' class='form-control' placeholder='Last Name' />" +
            "<input id='age' type='text' name='people[" + id + "].age' class='form-control' placeholder='Age' />");
        id++;

    })
   
});