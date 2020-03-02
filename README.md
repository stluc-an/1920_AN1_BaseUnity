# AN1_2020_base

Pour
- vous montrer deux approches de plans 2D dans Unity
- et ce qu'on peut faire avec l'un ou l'autre
- plus une démo du script simple de déplacement de la caméra (\Assets\Scripts\CharacterMove.cs) - nécessite un [Character Controller](https://docs.unity3d.com/Manual/class-CharacterController.html) sur la caméra
- et un script qui règle le problème d'objets 3D qui passent devant les autres de façon intempestive (FixZIndex.cs)

## Les 4 scènes
- Sprites : utilisation des [sprites simples](https://docs.unity3d.com/Manual/Sprites.html) (avantages : ça respecte la taille et la couleur de l'image)
- Quads (3D) - lights : utilisation de quads texturés (avantage : on peut jouer avec l'éclairage de Unity, et ses ombres!)
- Quads (3D) - [baked lights](https://docs.unity3d.com/Manual/LightModes.html) : quand on a de l'éclairage complexe qui ne doit pas bouger (non dynamique), on peut faire de l'éclairage pré-calculé (baked). Ça donne [des effets de lumière plus complexes](https://docs.unity3d.com/Manual/GIIntro.html) (éclairage indirect = lumière qui rebondit sur les objets et en éclaire d'autres) et de meilleures performances
- Quads (3D) - [post-processing](https://docs.unity3d.com/Packages/com.unity.postprocessing@2.3/manual/index.html) : autre utilisation intéressante des quads : utiliser le post-processing de Unity (effets de caméra)