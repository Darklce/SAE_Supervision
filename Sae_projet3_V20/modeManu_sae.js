var bras_tri = document.getElementById("I_trans_bras_tri").innerHTML;
var bras_usin = document.getElementById("I_trans_bras_usin").innerHTML;
var bras_rentre = document.getElementById("I_trans_bras_rentre").innerHTML;
var bras_sorti = document.getElementById("I_trans_bras_sorti").innerHTML;
var piece_saisie = document.getElementById("I_trans_piece_saisie").innerHTML;
var verin_bas = document.getElementById("I_tran_verin_bas").innerHTML;
var verin_haut = document.getElementById("I_trans_verin_haut").innerHTML;
var tri_noire_rentre = document.getElementById("I_tri_aig_noire_rentre").innerHTML;
var tri_noire_sorti = document.getElementById("I_tri_aig_noire_sorti").innerHTML;
var tri_rouge_rentre = document.getElementById("I_tri_aig_rouge_rentre").innerHTML;
var tri_rouge_sorti = document.getElementById("I_tri_aig_rouge_sorti").innerHTML;
var piece_goulotte = document.getElementById("I_tri_det_piece_goulotte").innerHTML;
var piece_tapis = document.getElementById("I_tri_piece_tapis").innerHTML;
var mode_manu = document.getElementById("M_Mode_Manu_Web").innerHTML;

function RetourAccueil(){
	window.location.href='web_projet_3';
}

function ActiveManu(){
	document.forms["form_mode"].submit();
}

function deplacer_tri_mousedown(){
	document.getElementById('M_trans_bras_tri_web').value="1";
	document.forms["mon_form"].submit();
}
function deplacer_usin_mousedown(){
	document.getElementById('M_trans_bras_usin_web').value="1";

	document.forms["mon_form"].submit();
}
function rentrer_bras_mousedown(){
	document.getElementById('M_trans_bras_rentre_web').value="1";
	document.forms["mon_form"].submit();
}
function sortir_bras_mousedown(){
	document.getElementById('M_trans_bras_sorti_web').value="1";
	document.forms["mon_form"].submit();
}
function saisir_piece_mousedown(){
	document.getElementById('M_saisir_piece_web').value="1";
	document.getElementById('M_lacher_piece_web').value="0";
	document.forms["mon_form"].submit();
}
function lacher_piece_mousedown(){
	document.getElementById('M_lacher_piece_web').value="1";
	document.getElementById('M_saisir_piece_web').value="0";
	document.forms["mon_form"].submit();
}
function descendre_verin_mousedown(){
	document.getElementById('M_descendre_verin_web').value="1";
	document.forms["mon_form"].submit();
}
function sortir_noire_mousedown(){
	document.getElementById('M_tri_piece_noire_sortir_web').value="1";
	document.forms["mon_form"].submit();
}
function sortir_rouge_mousedown(){
	document.getElementById('M_tri_piece_rouge_sortir_web').value="1";
	document.forms["mon_form"].submit();
}
function sortir_barriere_mousedown(){
	document.getElementById('M_tri_barriere_sortir_web').value="1";
	document.forms["mon_form"].submit();
}
function rotation_tapis_mousedown(){
	document.getElementById('M_rotation_tapis_web').value="1";
	document.forms["mon_form"].submit();
}
function raz_mouseup(){
	document.getElementById('M_descendre_verin_web').value="0";
	document.getElementById('M_tri_piece_noire_sortir_web').value="0";
	document.getElementById('M_tri_piece_rouge_sortir_web').value = "0";
	document.getElementById('M_tri_barriere_sortir_web').value="0";
	document.getElementById('M_rotation_tapis_web').value="0";
	document.getElementById('M_bouger_bras_usin_web').value="0";
	document.getElementById('M_bouger_bras_tri_web').value="0";
	document.getElementById('M_sortir_bras_web').value="0";
	document.getElementById('M_rentrer_bras_web').value="0";
	document.getElementById('M_lacher_piece_web').value="0";
	document.getElementById('M_saisir_piece_web').value="0";
	document.forms["mon_form"].submit();
}

function changerCouleurVoyant_bras_rentre(valeur) {
     // Changez la couleur du voyant en fonction de la valeur de la variable
     if (valeur === "1") {
         document.getElementById('Svoyant_bras_rentre').classList.add("green");
     } else if (valeur=="0"){
         document.getElementById('Svoyant_bras_rentre').classList.add("red");
     }
 }
function changerCouleurVoyant_bras_sorti(valeur) {
     // Changez la couleur du voyant en fonction de la valeur de la variable
     if (valeur === "1") {
         document.getElementById('Svoyant_bras_sorti').classList.add("green");
     } else if (valeur=="0"){
         document.getElementById('Svoyant_bras_sorti').classList.add("red");
     }
 }	
function changerCouleurVoyant_bras_tri(valeur) {
     // Changez la couleur du voyant en fonction de la valeur de la variable
     if (valeur === "1") {
         document.getElementById('Svoyant_bras_tri').classList.add("green");
     } else if (valeur=="0"){
         document.getElementById('Svoyant_bras_tri').classList.add("red");
     }
 }
function changerCouleurVoyant_bras_usin(valeur) {
     // Changez la couleur du voyant en fonction de la valeur de la variable
     if (valeur === "1") {
         document.getElementById('Svoyant_bras_usin').classList.add("green");
     } else if (valeur=="0"){
         document.getElementById('Svoyant_bras_usin').classList.add("red");
     }
 }	 
	