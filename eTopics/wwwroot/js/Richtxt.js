﻿window.tinymce.init({
    selector: '#TINYMCE',
    autoresize_min_height: 200,
    plugins: 'autosave preview searchreplace visualchars image link media fullscreen code codesample table hr pagebreak autoresize nonbreaking anchor insertdatetime advlist lists textcolor wordcount imagetools colorpicker',
    menubar: "edit view format insert table",
    toolbar1: 'formatselect | bold italic blockquote forecolor backcolor | imageupload link | alignleft aligncenter alignright  | numlist bullist outdent indent | fullscreen',
    selection_toolbar: 'bold italic | quicklink h2 h3 blockquote',
    autoresize_bottom_margin: 0,
    paste_data_images: true,
    image_advtab: true,
    file_picker_types: 'image',
    relative_urls: false,
    convert_urls: false,
    branding: false,

    setup: function (editor) {
        editor.addButton('imageupload', {
            icon: "image",
            onclick: function () {
                var fileInput = document.createElement("input");
                fileInput.type = "file";
                fileInput.multiple = true;
                fileInput.accept = "image/*";
                fileInput.addEventListener("change", handleFileSelect, false);
                fileInput.click();
            }
        });
    }
});