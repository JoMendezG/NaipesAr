PImage led;

void setup() {
  //size(147, 232);
  size(294, 464);

  led = loadImage("SimboloLed@2x.png");
}

void draw() {
  background(255);

  pushMatrix();
  translate(0,530);
  rotate(radians(360));
  led();
  popMatrix();
  
  //noLoop();
  
}

void led() {
  for (int i=-0; i<10; i++) {
    for (int j=-100; j<10; j++) {
      image(led, i*120-30, j*100, 105, 39);
      image(led, i*120-90, 50+j*100, 105, 39);
    }
  }
}

void keyPressed() {
  if (key == 'r') {
    redraw();
  }else if (key== 's') {
    saveFrame("captura_###.png"); //PNG es recomendado, pero se puede cambiar la extension a .jpg
  }
  
 
}
