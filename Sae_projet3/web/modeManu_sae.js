function rentrer_bras_mousedown(){
                document.getElementById('M_trans_bras_rentre_web').value = "1";
                document.forms["mon_form"].submit();
            }                    
			
			function sortir_bras_mousedown(){
                document.getElementById('M_trans_bras_sorti_web').value = "1";
                document.forms["mon_form"].submit();
            }                     
			
			function dep_tri_mousedown(){
                document.getElementById('M_trans_bras_tri_web').value = "1";
                document.forms["mon_form"].submit();
            }           
			
			function dep_usin_mousedown(){
                document.getElementById('M_trans_bras_usin_web').value = "1";
                document.forms["mon_form"].submit();
            }
			function saisir_piece_mousedown(){
				document.getElementById('M_piece_saisie_web').value = "1";
				document.forms["mon_form"].submit();
			} 
			function lacher_piece_mousedown(){
				document.getElementById('M_piece_lachee_web').value = "1";
				document.forms["mon_form"].submit();
			} 
			function rotation_tapis_mousedown(){
				document.getElementById('M_tapis_web').value = "1";
				document.forms["mon_form"].submit();
			} 
			function barriere_mousedown(){
				document.getElementById('M_barriere_web').value = "1";
				document.forms["mon_form"].submit();
			} 
			function tri_noire_mousedown(){
				document.getElementById('M_piece_noire_web').value = "1";
				document.forms["mon_form"].submit();
			} 
			function tri_rouge_mousedown(){
				document.getElementById('M_piece_rouge_web').value = "1";
				document.forms["mon_form"].submit();
			} 			
            function raz_mouseup(){
                document.getElementById('M_trans_bras_rentre_web').value = "0";
				document.getElementById('M_trans_bras_sorti_web').value = "0";
				document.getElementById('M_trans_bras_tri_web').value = "0";
				document.getElementById('M_trans_bras_usin_web').value = "0";
				document.getElementById('M_piece_saisie_web').value = "0";
				document.getElementById('M_piece_lachee_web').value = "0";
				document.getElementById('M_tapis_web').value = "0";
				document.getElementById('M_barriere_web').value = "0";
				document.getElementById('M_piece_noire_web').value = "0";
				document.getElementById('M_piece_rouge_web').value = "0";
                document.forms["mon_form"].submit();
            }