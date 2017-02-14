using UnityEngine;

public class MerlinVertex : Vertex {
	
   public void OnTriggerEnter(Collider col){

        string objName = col.gameObject.name;


   if(objName.Equals("Agent") || objName.Equals("Player")) {

			
		VertexReport report = new VertexReport(id, col.gameObject);
		SendMessageUpwards("Add Location", report);

		}
	}

   public void OnTriggerExit(Collider col) {
		string objName = col.gameObject.name;
		if(objName.Equals("Agent") || objName.Equals("Player"))
		{
			VertexReport report = new VertexReport(id, col.gameObject);
			SendMessageUpward("RemoveLocation", report);
		
		}

	}

}
