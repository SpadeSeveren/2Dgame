using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public struct TileData {
    public char character;
    public GameObject obj;
}

public class LevelLoad : MonoBehaviour {
    public GameObject red_bricks_tile,
                      blue_bricks_tile;
    public string map;

    enum Tile : int {
        Air,
        RedBricks,
        BlueBricks,
    } 

    void LoadLevel() {
        TileData[] tiles = {
            new TileData() { character = ' ', obj = null },
            new TileData() { character = '#', obj = red_bricks_tile },
            new TileData() { character = '$', obj = blue_bricks_tile },
        };
        
        StreamReader reader = new StreamReader(map);
        string text = reader.ReadToEnd();
        print(text);

        int read_pos_x = 0,
            read_pos_y = 0;

        for(int i = 0; i < text.Length; ++i) {
            if(text[i] == '\n') {
                read_pos_x = 0;
                ++read_pos_y;
            }
            else {
                print("A");
                for(int j = 1; j < tiles.Length; ++j) {
                    if(text[i] == tiles[j].character) {
                        Transform transform = tiles[j].obj.transform;
                        print("B");
                        transform.position = new Vector2(read_pos_x * transform.localScale.x, read_pos_y * transform.localScale.y);
                        print("C");
                        GameObject new_tile = Instantiate(tiles[j].obj, transform) as GameObject;
                        print("D");
                        break;
                    }
                }
                ++read_pos_x;
                print("E");
            }
        }
    }

    void Start() {
	    LoadLevel();     	
	}	
}
