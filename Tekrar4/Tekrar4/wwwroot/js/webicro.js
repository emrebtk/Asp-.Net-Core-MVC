ClassicEditor
    .create(document.querySelector('.editor'), {
        ckfinder: {
            uploadUrl: '/panel/yonetim/UploadImage',
        }
    })
    .then(newEditor => {
        editor = newEditor;
    })
    .catch(error => {
        console.error(error);
    });


document.querySelector('#answer').addEventListener('click', () => {
    const editorData = editor.getData();
    document.getElementById('editor').value = editorData;
});

//ClassicEditor.replace('Post',
//    {
//        filebrowserImageUploadUrl: '@Url.Action("UploadImage", "Yonetim")',
//        filebrowserImageBrowseUrl: '@Url.Action("UploadedImages", "Yonetim")'
//    }
//);
