# RigidbodyBug
This demonstrates a bug that causes NaN values in the colliders.

The project creates instances from a prefab structure and then adds a Rigidbody component. The prefab is inactive and the scale is zero. After instantiation, a Rigidbody is added, the object is turned on, and the scale is set to one.

On the PC platform this runs as expected. On the Xbox platforms, thie causes NaN in collider messages and the objects do not show.
