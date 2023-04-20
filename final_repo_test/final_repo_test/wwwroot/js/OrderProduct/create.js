function readUrl(input, image) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            image.attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}