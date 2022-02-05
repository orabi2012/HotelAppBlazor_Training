ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Hotel App")
    }

    if (type === "error") {
        toastr.error(message, "Hotel App")
    }

}