window.applyCpfMask = function (element) {
    element.addEventListener("input", function () {
        let v = element.value.replace(/\D/g, "");
        if (v.length > 11) v = v.substring(0, 11);

        v = v.replace(/(\d{3})(\d)/, "$1.$2");
        v = v.replace(/(\d{3})(\d)/, "$1.$2");
        v = v.replace(/(\d{3})(\d{1,2})$/, "$1-$2");

        element.value = v;
    });
}

window.applyPhoneMask = function (element) {
    element.addEventListener("input", function () {
        let v = element.value.replace(/\D/g, "");
        if (v.length > 11) v = v.substring(0, 11);

        v = v.replace(/^(\d{2})(\d)/g, "($1) $2");
        v = v.replace(/(\d{5})(\d)/, "$1-$2");

        element.value = v;
    });
}
