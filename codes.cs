foreach ( var go in gameObjects ) {
				Transform t = go.transform;
				if (!makeSubmeshes)
				{
					meshString.Append("g ").Append(t.name).Append("\n");
				}
				meshString.Append(ProcessTransform(t, makeSubmeshes));
			}
			
			WriteToFile(meshString.ToString(), fileName);
			if ( fileName.StartsWith ( Application.dataPath ) ) {
				AssetDatabase.ImportAsset( "Assets" + fileName.Substring( Application.dataPath.Length ) );
			}
			
			// end
			StartIndex = 0;
			Debug.Log("ObjExport: saved .OBJ to " + fileName);
			return fileName;
		}

if (mf != null)
			{
				meshString.Append(ObjExport.MeshToString(mf, t));
			}
			
			for(int i = 0; i < t.childCount; i++)
			{
				meshString.Append(ProcessTransform(t.GetChild(i), makeSubmeshes));
			}
			
			return meshString.ToString();
		}
		
