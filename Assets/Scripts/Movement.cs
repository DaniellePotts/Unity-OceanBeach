using UnityEngine;

public class Movement : MonoBehaviour
{
    private GameObject Car;
    private int current;
    public float speed;
    public Transform[] target;

    private int maxCycle = 2;
    private int currCycle = 0;
    private Transform start;
    private void Start()
    {
        Car = gameObject;
        start = Car.transform;
    }

    // Update is called once per frame

    private void Update()
    {
        if (Car.transform.position == target[target.Length - 1].position)
        {
            currCycle += 1;
        }

        if (currCycle <= maxCycle)
        {
            if (Car.transform.position == target[2].position)
            {
                speed = 15;
            }

            if (Car.transform.position == target[0].position)
            {
                speed = 5;
            }

            if (Car.transform.position == target[3].position)
            {
                speed = 10;
            }


            if (Car.transform.position != target[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(Car.transform.position, target[current].position,
                    speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);
            }
            else
            {
                current = (current + 1) % target.Length;
            }
        }
        else
        {
            Vector3 pos = Vector3.MoveTowards(Car.transform.position, start.transform.position,
                speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }

    }
}