
//Validar a entrada do usuário, permitindo apenas a inserção numérica
document.getElementById("valorInput").oninput = function () {
    this.value = this.value.replace(/[^0-9,]/g, '');
}
