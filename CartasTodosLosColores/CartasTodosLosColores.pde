int col; // Variable númerica que me entregara el random de morados.
int r;

color [] colModulos = new color[6]; // array de color que almacena mis 3 tonos morados
int [] rotar = new int [4];
int [] modulos = new int [2];

float anchBloque = 50;
float altoBloque = 50;

float cant;
void setup() {

  //size(148, 232);  
  size(294, 464);

  colModulos[0] = color(80, 38, 111);
  colModulos[1] = color(144, 58, 142);
  colModulos[2] = color(50, 58, 143);
  colModulos[3] = color(63, 129, 195);
  colModulos[4] = color(248, 196, 28);
  colModulos[5] = color(234, 98, 49);


  rotar[0] = 0;
  rotar[1] = 90;
  rotar[2] = 180;
  rotar[3] = 270;

  noStroke();
  rectMode(CENTER);
}

void draw() {

  background(255);

  for (int i = 0; i < 7; i++) {
    for (int j = 0; j < 10; j++) {
      cant = random(0, 3);
      modMorados(i*anchBloque, j*altoBloque+altoBloque/10, anchBloque, altoBloque);
    }
  }

  noLoop();
}

void modMorados(float posX, float posY, float tamX, float tamY) {

  int select = int(cant);

  if (select == 0) {
    pat1(posX, posY, tamX, tamY);
  } else if (select == 1) {
    pat2(posX, posY, tamX, tamY);
  } else if (select == 2) {
    pat3(posX, posY, tamX, tamY);
  }
}

void pat1(float posX, float posY, float tamX, float tamY) {
  r= (rotar[(int)random(0, 4)]);
  pushMatrix();
  translate(posX, posY);
  rotate(radians(r));

  noStroke();
  col = color(colModulos[(int)random(0, 6)]);
  fill(col);
  rect(0, 0, tamX, tamY);

  col = color(colModulos[(int)random(0, 6)]); 
  fill(col);
  ellipse(0, 0, tamX/2, tamY/2);


  fill(255, random(10, 30));
  triangle(0-tamX/2, 0+tamY/2, 0+tamX/2, 0+tamY/2, 0+tamX/2, 0-tamY/2);
  popMatrix();
}

void pat2 (float posX, float posY, float tamX, float tamY) {
  color same =col = color(colModulos[(int)random(0, 6)]); 

  r= (rotar[(int)random(0, 4)]);
  pushMatrix();
  translate(posX, posY);
  rotate(radians(r));

  fill(same);
  stroke(same);
  strokeWeight(2);
  triangle(0, 0, 0-tamX/2, 0-tamY/2, 0+tamX/2, 0-tamY/2);
  triangle(0, 0, 0-tamX/2, 0+tamY/2, 0+tamX/2, 0+tamY/2);

  col = color(colModulos[(int)random(0, 6)]); 
  fill(col);
  stroke(col);
  triangle(0, 0, 0-tamX/2, 0-tamY/2, 0-tamX/2, 0+tamY/2);
  triangle(0, 0, 0+tamX/2, 0+tamY/2, 0+tamX/2, 0-tamY/2);

  fill(same);
  ellipse(0+tamX/3, 0, tamX/4, tamY/4);
  ellipse(0-tamX/3, 0, tamX/4, tamY/4);

  fill(255, random(0, 30));
  noStroke();
  rect(0, 0, tamX, tamY);

  popMatrix();
}

void pat3 (float posX, float posY, float tamX, float tamY) {
  r= (rotar[(int)random(0, 4)]);

  pushMatrix();
  translate(posX, posY);
  rotate(radians(r));

  col = color(colModulos[(int)random(0, 6)]); 
  fill(col);
  noStroke();
  rect(0, 0, tamX, tamY);

  col = color(colModulos[(int)random(0, 6)]); 
  fill(col);
  ellipse(0-tamX/4, 0+tamY/4, tamX/4, tamY/4);
  ellipse(0+tamX/4, 0+tamY/4, tamX/4, tamY/4);
  ellipse(0+tamX/4, 0-tamY/4, tamX/4, tamY/4);
  ellipse(0-tamX/4, 0-tamY/4, tamX/4, tamY/4);

  fill(255, random(10, 30));
  triangle(0-tamX/2, 0+tamY/2, 0+tamX/2, 0+tamY/2, 0+tamX/2, 0-tamY/2);
  popMatrix();
}

void keyPressed() {
  if ( key == 'a' ) {           
    redraw();
  } else if (key== 'r') {
    saveFrame("captura_###.png"); //PNG es recomendado, pero se puede cambiar la extension a .jpg
  }
}
