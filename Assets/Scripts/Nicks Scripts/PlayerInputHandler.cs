using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    private ICommand shootCommand;
    public Weapon weapon;

    private void Start()
    {
        shootCommand = new ShootCommand(weapon);

    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootCommand.Execute();
        }
    }

}
